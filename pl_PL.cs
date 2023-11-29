using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator;


namespace Polish
{
    public class pl_PL : ILanguage
    {
        public string Name => "Polski";
        public string formSettings_btnSave => "Zapisz";
        public string formSettings_btnCancel => "Anuluj";
        public string formSettings_Text => "Opcje:";
        public string formSettings_labelOptions => "Opcje:";

        public string videoControlBar_labelSubtilesOnOffText => "Napisy:";
        public string videoControlBar_labelOn => "Wł.";
        public string videoControlBar_labelOff => "Wył.";
        public string videoControlBar_fullscreenOff => "Pełny ekran Wył.";
        public string videoControlBar_fullscreenOn => "Pełny ekran Wł.";
        public string videoControlBar_startTxt => "Start";
        public string videoControlBar_subtilesOn => "Napisy Wł.";
        public string videoControlBar_subtilesOff => "Napisy Wył.";
    }
}