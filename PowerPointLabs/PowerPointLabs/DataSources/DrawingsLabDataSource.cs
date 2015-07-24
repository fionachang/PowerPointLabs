﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PowerPointLabs.DataSources
{
    public class DrawingsLabDataSource : INotifyPropertyChanged
    {
        public enum Alignment
        {
            TopLeft,
            TopCenter,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight,
        }

        public enum Vertical
        {
            Top,
            Middle,
            Bottom,
        }

        public enum Horizontal
        {
            Left,
            Center,
            Right,
        }

        # region Properties
        private float shiftValueX;

        public float ShiftValueX
        {
            get { return shiftValueX; }
            set
            {
                shiftValueX = value;
                OnPropertyChanged("ShiftValueX");
            }
        }

        private float shiftValueY;

        public float ShiftValueY
        {
            get { return shiftValueY; }
            set
            {
                shiftValueY = value;
                OnPropertyChanged("ShiftValueY");
            }
        }

        private float shiftValueRotation;

        public float ShiftValueRotation
        {
            get { return shiftValueRotation; }
            set
            {
                shiftValueRotation = value;
                OnPropertyChanged("ShiftValueRotation");
            }
        }

        private bool shiftIncludePosition = true;

        public bool ShiftIncludePosition
        {
            get { return shiftIncludePosition; }
            set
            {
                shiftIncludePosition = value;
                OnPropertyChanged("ShiftIncludePosition");
            }
        }

        private bool shiftIncludeRotation = true;

        public bool ShiftIncludeRotation
        {
            get { return shiftIncludeRotation; }
            set
            {
                shiftIncludeRotation = value;
                OnPropertyChanged("ShiftIncludeRotation");
            }
        }

        private float savedValueX;

        public float SavedValueX
        {
            get { return savedValueX; }
            set
            {
                savedValueX = value;
                OnPropertyChanged("SavedValueX");
            }
        }

        private float savedValueY;

        public float SavedValueY
        {
            get { return savedValueY; }
            set
            {
                savedValueY = value;
                OnPropertyChanged("SavedValueY");
            }
        }

        private float savedValueRotation;

        public float SavedValueRotation
        {
            get { return savedValueRotation; }
            set
            {
                savedValueRotation = value;
                OnPropertyChanged("SavedValueRotation");
            }
        }

        private bool savedIncludePosition = true;

        public bool SavedIncludePosition
        {
            get { return savedIncludePosition; }
            set
            {
                savedIncludePosition = value;
                OnPropertyChanged("SavedIncludePosition");
            }
        }

        private bool savedIncludeRotation = true;

        public bool SavedIncludeRotation
        {
            get { return savedIncludeRotation; }
            set
            {
                savedIncludeRotation = value;
                OnPropertyChanged("SavedIncludeRotation");
            }
        }
        # endregion

        private Horizontal _anchorHorizontal;
        private Vertical _anchorVertical;

        public Horizontal AnchorHorizontal
        {
            get { return _anchorHorizontal; }
            set
            {
                _anchorHorizontal = value;
                OnPropertyChanged("Anchor");
            }
        }

        public Vertical AnchorVertical
        {
            get { return _anchorVertical; }
            set
            {
                _anchorVertical = value;
                OnPropertyChanged("Anchor");
            }
        }

        public Alignment Anchor
        {
            get
            {
                return HorizontalVerticalToAlignment(_anchorHorizontal, _anchorVertical);
            }
            set
            {
                AlignmentToHorizontalVertical(value, out _anchorHorizontal, out _anchorVertical);
                OnPropertyChanged("Anchor");
            }
        }

        private static Alignment HorizontalVerticalToAlignment(Horizontal horizontal, Vertical vertical)
        {
            switch (horizontal)
            {
                case Horizontal.Left:
                    switch (vertical)
                    {
                        case Vertical.Top:
                            return Alignment.TopLeft;
                        case Vertical.Middle:
                            return Alignment.MiddleLeft;
                        case Vertical.Bottom:
                            return Alignment.BottomLeft;
                    }
                    break;
                case Horizontal.Center:
                    switch (vertical)
                    {
                        case Vertical.Top:
                            return Alignment.TopCenter;
                        case Vertical.Middle:
                            return Alignment.MiddleCenter;
                        case Vertical.Bottom:
                            return Alignment.BottomCenter;
                    }
                    break;
                case Horizontal.Right:
                    switch (vertical)
                    {
                        case Vertical.Top:
                            return Alignment.TopRight;
                        case Vertical.Middle:
                            return Alignment.MiddleRight;
                        case Vertical.Bottom:
                            return Alignment.BottomRight;
                    }
                    break;
            }
            throw new IndexOutOfRangeException();
        }

        private static void AlignmentToHorizontalVertical(Alignment alignment, out Horizontal horizontal, out Vertical vertical)
        {
            switch (alignment)
            {
                case Alignment.BottomLeft:
                    vertical = Vertical.Bottom;
                    horizontal = Horizontal.Left;
                    return;
                case Alignment.BottomCenter:
                    vertical = Vertical.Bottom;
                    horizontal = Horizontal.Center;
                    return;
                case Alignment.BottomRight:
                    vertical = Vertical.Bottom;
                    horizontal = Horizontal.Right;
                    return;
                case Alignment.MiddleLeft:
                    vertical = Vertical.Middle;
                    horizontal = Horizontal.Left;
                    return;
                case Alignment.MiddleCenter:
                    vertical = Vertical.Middle;
                    horizontal = Horizontal.Center;
                    return;
                case Alignment.MiddleRight:
                    vertical = Vertical.Middle;
                    horizontal = Horizontal.Right;
                    return;
                case Alignment.TopLeft:
                    vertical = Vertical.Top;
                    horizontal = Horizontal.Left;
                    return;
                case Alignment.TopCenter:
                    vertical = Vertical.Top;
                    horizontal = Horizontal.Center;
                    return;
                case Alignment.TopRight:
                    vertical = Vertical.Top;
                    horizontal = Horizontal.Right;
                    return;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        # region Event Implementation
        public event PropertyChangedEventHandler PropertyChanged = delegate {};

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        # endregion
    }
}
