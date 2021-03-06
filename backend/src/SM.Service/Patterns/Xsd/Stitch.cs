﻿namespace SM.Service.Patterns
{
    public class Stitch
    {
        public enum StitchType
        {
            Undefined,
            Full,
            HalfTop,
            HalfBottom = 4,
            ThreeQuarterTL = 8,
            ThreeQuarterTR = 16,
            ThreeQuarterBR = 32,
            ThreeQuarterBL = 64,
            QuarterTL = 128,
            QuarterTR = 256,
            QuarterBR = 512,
            QuarterBL = 1024,
            PetitTL = 2048,
            PetitTR = 4096,
            PetitBR = 8192,
            PetitBL = 16384
        }

        private Color color;

        private StitchType type;

        public ushort Count;

        public uint Offset;

        public Color Color
        {
            get => color;
            set
            {
                color = value;
                SetColorItems();
            }
        }

        public StitchType Type
        {
            get => type;
            set
            {
                type = value;
                SetColorItems();
            }
        }

        public Pattern.ItemType ItemType
        {
            get
            {
                Pattern.ItemType result;
                if (Type <= StitchType.QuarterTL)
                {
                    if (Type <= StitchType.ThreeQuarterTR)
                    {
                        switch (Type)
                        {
                            case StitchType.Full:
                                result = Pattern.ItemType.Full;
                                return result;
                            case StitchType.HalfTop:
                            case StitchType.HalfBottom:
                                result = Pattern.ItemType.Half;
                                return result;
                            case (StitchType) 3:
                                goto NONE;
                            default:
                                if (Type != StitchType.ThreeQuarterTL && Type != StitchType.ThreeQuarterTR)
                                    goto NONE;
                                break;
                        }
                    }
                    else if (Type != StitchType.ThreeQuarterBR && Type != StitchType.ThreeQuarterBL)
                    {
                        if (Type != StitchType.QuarterTL)
                            goto NONE;
                        goto QUARTER;
                    }
                    result = Pattern.ItemType.ThreeQuarter;
                    return result;
                }
                if (Type > StitchType.QuarterBL)
                {
                    if (Type <= StitchType.PetitTR)
                    {
                        if (Type != StitchType.PetitTL && Type != StitchType.PetitTR)
                            goto NONE;
                    }
                    else if (Type != StitchType.PetitBR && Type != StitchType.PetitBL)
                    {
                        goto NONE;
                    }
                    result = Pattern.ItemType.Petit;
                    return result;
                }
                if (Type != StitchType.QuarterTR && Type != StitchType.QuarterBR && Type != StitchType.QuarterBL)
                    goto NONE;
                QUARTER:
                result = Pattern.ItemType.Quarter;
                return result;
                NONE:
                result = Pattern.ItemType.None;
                return result;
            }
        }

        private void SetColorItems()
        {
            if (Color == null || Type == StitchType.Undefined)
                return;
            if (Type <= StitchType.QuarterTL)
            {
                if (Type <= StitchType.ThreeQuarterTR)
                {
                    switch (Type)
                    {
                        case StitchType.HalfTop:
                        case StitchType.HalfBottom:
                            Color.HasItems |= Pattern.ItemType.Half;
                            return;
                        case (StitchType) 3:
                            goto FULL;
                        default:
                            if (Type != StitchType.ThreeQuarterTL && Type != StitchType.ThreeQuarterTR)
                                goto FULL;
                            break;
                    }
                }
                else if (Type != StitchType.ThreeQuarterBR && Type != StitchType.ThreeQuarterBL)
                {
                    if (Type != StitchType.QuarterTL)
                        goto FULL;
                    goto QUARTER;
                }
                Color.HasItems |= Pattern.ItemType.ThreeQuarter;
                return;
            }
            if (Type > StitchType.QuarterBL)
            {
                if (Type <= StitchType.PetitTR)
                {
                    if (Type != StitchType.PetitTL && Type != StitchType.PetitTR)
                        goto FULL;
                }
                else if (Type != StitchType.PetitBR && Type != StitchType.PetitBL)
                {
                    goto FULL;
                }
                Color.HasItems |= Pattern.ItemType.Petit;
                return;
            }
            if (Type != StitchType.QuarterTR && Type != StitchType.QuarterBR && Type != StitchType.QuarterBL)
                goto FULL;
            QUARTER:
            Color.HasItems |= Pattern.ItemType.Quarter;
            return;
            FULL:
            Color.HasItems |= Pattern.ItemType.Full;
        }
    }
}