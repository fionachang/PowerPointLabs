﻿namespace PowerPointLabs
{
    internal class TextCollection
    {
        # region URLs
        public const string FeedbackUrl = "http://powerpointlabs.info/contact.html";
        public const string HelpDocumentUrl = "http://powerpointlabs.info/docs.html";
        public const string PowerPointLabsWebsiteUrl = "http://PowerPointLabs.info";
        # endregion

        # region Ribbon XML
        # region Supertips
        public const string AddAnimationButtonSupertip =
            "Creates an animation slide to transition from the currently selected slide to the next slide.";
        public const string ReloadButtonSupertip =
            "Recreates an existing animation slide with new animations.\n\n" +
            "To activate, select the original slide or the animation slide then click this button.";
        public const string InSlideAnimateButtonSupertip =
            "Moves a shape around the slide in multiple steps.\n\n" +
            "To activate, copy the shape to locations where it should stop, select the copies in the order they should appear, then click this button";
        
        public const string AddZoomInButtonSupertip =
            "Creates an animation slide with a zoom-in effect from the currently selected shape to the next slide.\n\n" +
            "To activate, select a rectangle shape on the slide to drill down from, then click this button.";
        public const string AddZoomOutButtonSupertip =
            "Creates an animation slide with a zoom-out effect from the previous slide to the currently selected shape.\n\n" +
            "To activate, select a rectangle shape on the slide to step back to, then click this button.";
        public const string ZoomToAreaButtonSupertip =
            "Zoom into an area of a slide or image.\n\nTo activate, place a rectangle shape on the portion to magnify, then click this button.\n\n" +
            "This feature works best with high-resolution images.";
        
        public const string MoveCropShapeButtonSupertip =
            "Crop a picture to a custom shape.\n\n" +
            "To activate, draw one or more shapes upon the picture to crop, select the shape(s), then click this button.";
        public const string AddSpotlightButtonSupertip =
            "Creates a spotlight effect for a selected shape.\n\n" +
            "To activate, draw a shape that the spotlight should outline, select it, then click this button.";
        public const string ReloadSpotlightButtonSupertip =
            "Adjusts the transparency and edges of an existing spotlight.\n\n" +
            "To activate, set the transparency level and soft edges width, select the existing spotlight shape, then click this button.";
        public const string AddAudioButtonSupertip =
            "Creates synthesized narration from text in the Speaker Notes pane of the selected slides.";
        public const string GenerateRecordButtonSupertip =
            "Creates synthesized narration from text in a slide's Speaker Notes pane.";
        public const string AddRecordButtonSupertip =
            "Manually record audio to replace synthesized narration.";
        public const string RemoveAudioButtonSupertip =
            "Removes synthesized audio added using Auto Narrate from the selected slides."; 
        public const string AddCaptionsButtonSupertip =
            "Creates movie-style subtitles from text in the Speaker Notes pane, and adds it to the selected slides.";
        public const string RemoveCaptionsButtonSupertip =
            "Removes captions added using Auto Captions from the selected slides.";
        public const string HighlightBulletsTextButtonSupertip =
            "Highlights selected bullet points by changing the text's color.\n\n" +
            "To activate, select the bullet points to highlight, then click this button.";
        public const string HighlightBulletsBackgroundButtonSupertip =
            "Highlights selected bullet points by changing the text's background color.\n\n" +
            "To activate, select the bullet points to highlight, then click this button.";
        public const string HighlightTextFragmentsButtonSupertip =
            "Highlights the selected text fragments.\n\n" +
            "To activate, select the text to highlight, then click this button.";
        public const string ColorPickerButtonSupertip = @"Opens Custom Color Picker";
        public const string CustomeShapeButtonSupertip = @"Manage your custom shapes."; // Custome -> Custom?
        public const string HelpButtonSupertip = @"Click this to visit PowerPointLabs help page in our website.";
        public const string FeedbackButtonSupertip = @"Click this to email us problem reports or other feedback. ";
        public const string AboutButtonSupertip = @"Information about the PowerPointLabs plugin.";
        # endregion

        # region Tab Labels
        public const string PowerPointLabsAddInsTabLabel = "PowerPointLabs";
        # endregion

        # region Button Labels
        public const string CombineShapesLabel = "Combine Shapes";

        public const string AutoAnimateGroupLabel = "Auto Animate";
        public const string AddAnimationButtonLabel = "Add Animation Slide";
        public const string AddAnimationReloadButtonLabel = "Recreate Animation";
        public const string AddAnimationInSlideAnimateButtonLabel = "Animate In Slide";

        public const string AutoZoomGroupLabel = "Auto Zoom";
        public const string AddZoomInButtonLabel = "Drill Down";
        public const string AddZoomOutButtonLabel = "Step Back";
        public const string ZoomToAreaButtonLabel = "Zoom To Area";

        public const string AutoCropGroupLabel = "Auto Crop";
        public const string MoveCropShapeButtonLabel = "Crop To Shape";

        public const string SpotLightGroupLabel = "Spotlight";
        public const string AddSpotlightButtonLabel = "Create Spotlight";
        public const string ReloadSpotlightButtonLabel = "Recreate Spotlight";

        public const string EmbedAudioGroupLabel = "Auto Narrate";
        public const string AddAudioButtonLabel = "Add Audio";
        public const string GenerateRecordButtonLabel = "Generate Audio Automatically";
        public const string AddRecordButtonLabel = "Record Audio Manually";
        public const string RemoveAudioButtonLabel = "Remove Audio";

        public const string EmbedCaptionGroupLabel = "Auto Captions";
        public const string AddCaptionsButtonLabel = "Add Captions";
        public const string RemoveCaptionsButtonLabel = "Remove Captions";

        public const string HighlightBulletsGroupLabel = "Highlight Bullets";
        public const string HighlightBulletsTextButtonLabel = "Highlight Points";
        public const string HighlightBulletsBackgroundButtonLabel = "Highlight Background";
        public const string HighlightTextFragmentsButtonLabel = "Highlight Text";

        public const string LabsGroupLabel = "Labs";
        public const string ColorPickerButtonLabel = "Colors Lab";
        public const string CustomeShapeButtonLabel = "Shapes Lab";

        public const string PPTLabsHelpGroupLabel = "Help";
        public const string HelpButtonLabel = "Help";
        public const string FeedbackButtonLabel = "Report Issues/ Send Feedback";
        public const string AboutButtonLabel = "About";
        # endregion

        # region Context Menu Labels
        public const string NameEditShapeLabel = "Edit Name";
        public const string SpotlightShapeLabel = "Add Spotlight";
        public const string ZoomInContextMenuLabel = "Drill Down";
        public const string ZoomOutContextMenuLabel = "Step Back";
        public const string ZoomToAreaContextMenuLabel = "Zoom To Area";
        public const string HighlightBulletsMenuShapeLabel = "Highlight Bullets";
        public const string HighlightBulletsTextShapeLabel = "Highlight Text";
        public const string HighlightBulletsBackgroundShapeLabel = "Highlight Background";
        public const string ConvertToPictureShapeLabel = "Convert to Picture";
        public const string AddCustomShapeShapeLabel = "Add to Shapes Lab";
        public const string CutOutShapeShapeLabel = "Crop To Shape";
        public const string FitToWidthShapeLabel = "Fit To Width";
        public const string FitToHeightShapeLabel = "Fit To Height";
        public const string InSlideAnimateGroupLabel = "Animate In-Slide";
        public const string ApplyAutoMotionThumbnailLabel = "Add Animation Slide";
        public const string ContextSpeakSelectedTextLabel = "Speak Selected Text";
        public const string ContextAddCurrentSlideLabel = "Add Audio (Current Slide)";
        public const string ContextReplaceAudioLabel = "Replace Audio";
        # endregion
        # endregion

        # region Quick Tutorial Download Link

        //for release ver
//        public const string QuickTutorialLink = "http://www.comp.nus.edu.sg/~pptlabs/samples/tutorial.pptx";

        //for dev ver
        public const string QuickTutorialLink = "http://www.comp.nus.edu.sg/~pptlabs/samples/dev/tutorial.pptx";
        
        # endregion

        # region Ribbon
        public const string AboutInfo =
            "          PowerPointLabs Plugin Version 1.8.10 [Release date: 21 Jul 2014]\n     Developed at School of Computing, National University of Singapore.\n        For more information, visit our website " + PowerPointLabsWebsiteUrl;
        public const string AboutInfoTitle = "About PowerPointLabs";
        # endregion

        # region ThisAddIn
        public const string AccessTempFolderErrorMsg = "Error when accessing temp folder";
        public const string CreatTempFolderErrorMsg = "Error when creating temp folder";
        public const string ExtraErrorMsg = "Error when extracting";
        public const string PrepareMediaErrorMsg = "Error when preparing media files";
        public const string VersionNotCompatibleErrorMsg =
            "Some features of PowerPointLabs do not work with presentations saved in " +
            "the .ppt format. To use them, please resave the " +
            "presentation with the .pptx format.";
        public const string OnlinePresentationNotCompatibleErrorMsg =
        	"Some features of PowerPointLabs do not work with online presentations. " +
        	"To use them, please save the file locally.";
        public const string TabActivateErrorTitle = "Unable to activate 'Double Click to Open Property' feature";
        public const string TabActivateErrorDescription =
            "To activate 'Double Click to Open Property' feature, you need to enable 'Home' tab " +
            "in Options -> Customize Ribbon -> Main Tabs -> tick the checkbox of 'Home' -> click OK but" +
            "ton to save.";
        public const string ShapesLabTaskPanelTitle = "Shapes Lab";
        public const string ColorsLabTaskPanelTitle = "Colors Lab";
        public const string RecManagementPanelTitle = "Record Management";
        # endregion 

        # region ShapeGalleryPresentation
        public const string ShapeCorruptedError =
            "Some shapes in the Shapes Lab were corrupted, and have been deleted automatically.";
        # endregion

        # region CropToShape

        public class CropToShapeText
        {
            //------------ Msg -------------
            public const string ErrorMessageForSelectionCountZero = "To use 'Crop To Shape', please select at least one shape.";
            public const string ErrorMessageForSelectionNonShape = "'Crop To Shape' only supports shape objects.";
            public const string ErrorMessageForExceedSlideBound = "Please ensure your shape is within the slide.";
            public const string ErrorMessageForRotationNonZero = "In the current version, the 'Crop To Shape' feature does not" +
                                                                  " work if the shape is rotated";
            public const string ErrorMessageForUndefined = "Undefined error in 'Crop To Shape'.";
        }

        # endregion

        # region ConvertToPicture
        public const string ErrorTypeNotSupported = "Convert to Picture only supports Shapes and Charts.";
        public const string ErrorWindowTitle = "Unable to Convert to Picture";
        # endregion

        # region Task Pane - Recorder
        public const string RecorderInitialTimer = "00:00:00";
        public const string RecorderReadyStatusLabel = "Ready.";
        public const string RecorderRecordingStatusLabel = "Recording...";
        public const string RecorderPlayingStatusLabel = "Playing...";
        public const string RecorderPauseStatusLabel = "Pause";
        public const string RecorderUnrecognizeAudio = "Unrecognize Embedded Audio";
        public const string RecorderScriptStatusNoAudio = "No Audio";
        public const string RecorderWndMessageError = "Fatal error";
        public const string RecorderNoScriptDetail = "No Script Available";
        public const string RecorderNoInputDeviceMsg = "No Input Device suitable for the recording.\n" +
                                                       "Make sure your computer has a built-in voice picker and has been enabled, " +
                                                       "or an external voice input device has been connected.";
        public const string RecorderNoInputDeviceMsgBoxTitle = "Input Device Not Found";
        public const string RecorderSaveRecordMsg = "Do you want to save the record?";
        public const string RecorderSaveRecordMsgBoxTitle = "Save Record";
        public const string RecorderReplaceRecordMsgFormat = "Do you want to replace\n{0}\nwith current record?";
        public const string RecorderReplaceRecordMsgBoxTitle = "Replacement";
        public const string RecorderNoRecordToPlayError = "No record to play back. Please record first.";
        public const string RecorderInvalidOperation = "Invalid Operation";
        # endregion

        # region Task Pane - Colors Lab

        public class ColorsLabText
        {
            //----------- Tooltips -----------
            public const string MainColorBoxTooltips = "Use this to choose main color: " +
                                       "\r\nDrag the button to pick a color from an area in the screen, " +
                                       "\r\nor click the button to choose a color from the Color dialog.";
            public const string FontColorButtonTooltips = "Change FONT color of selected shapes: " +
                                                     "\r\nDrag the button to pick a color from an area in the screen, " +
                                                     "\r\nor click the button to choose a color from the Color dialog.";
            public const string LineColorButtonTooltips = "Change LINE color of selected shapes: " +
                                                     "\r\nDrag the button to pick a color from an area in the screen, " +
                                                     "\r\nor click the button to choose a color from the Color dialog.";
            public const string FillColorButtonTooltips = "Change FILL color of selected shapes: " +
                                                     "\r\nDrag the button to pick a color from an area in the screen, " +
                                                     "\r\nor click the button to choose a color from the Color dialog.";
            public const string BrightnessSliderTooltips = "Move the slider to adjust the main color’s brightness.";
            public const string SaturationSliderTooltips = "Move the slider to adjust the main color’s saturation.";
            public const string SaveFavoriteColorsButtonTooltips = "Save the favorite colors.";
            public const string LoadFavoriteColorsButtonTooltips = "Load existing favorite colors.";
            public const string ResetFavoriteColorsButtonTooltips = "Reset the current favorite colors to your last loaded ones.";
            public const string EmptyFavoriteColorsButtonTooltips = "Empty the favorite colors.";
            public const string ColorRectangleTooltips = "Click the color to select it as main color. You can drag-and-drop these colors into the favorites panel.";
            public const string ThemeColorRectangleTooltips = "Click the color to select it as main color.";

            //------------ Msg ------------
            public const string InfoHowToActivateFeature = "To use this feature, you may need to select at least one shape.";
        }
        
        # endregion

        # region Task Pane - Custom Shape
        public const string CustomShapeFileNameInvalid = "Invalid shape name encountered";
        public const string CustomShapeNoShapeTextFirstLine = "No shapes saved yet.";
        public const string CustomShapeNoShapeTextSecondLine = "Right-click any object in the slides to save it in this panel.";
        public const string CustomShapeNoPanelSelectedError = "No shape selected";
        public const string CustomShapeViewTypeNotSupported = "Shapes Lab does not support current view type.";
        # endregion

        # region Control - Labeled Thumbnail 
        public const string LabeledThumbnailTooLongNameError = "Name's length cannot exceed 255";
        public const string LabeledThumbnailInvalidCharacterError = "Empty name, '<', '>', ':', '\"', '/', '\\', '|', '?', and '*' are not allowed for the name";
        public const string LabeledThumbnailFileNameExistError = "File name is already used";
        # endregion

        # region Control - SlideShow Recorder Control
        public const string InShowControlInvalidRecCommandError = "Invalid Recording Command";
        public const string InShowControlRecButtonIdleText = "Stop and Advance";
        public const string InShowControlRecButtonRecText = "Start Recording";
        # endregion

        # region Error Dialog
        public const string UserFeedBack = " Help us fix the problem by emailing ";
        public const string Email = @"pptlabs@comp.nus.edu.sg";
        # endregion
    }
}
