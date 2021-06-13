function showDiv(element) {
    document.getElementById('ASPxSplitter1_Content_ContentSplitter_MainContent_ASPxPageControl1_pcAddDia_ASPxPanel1_ASPxFormLayout1_hddia').value = element.value;
    document.getElementById('ASPxSplitter1_Content_ContentSplitter_MainContent_ASPxPageControl1_pcAddDia_ASPxPanel1_ASPxFormLayout1_hddiatext').value = element.options[element.selectedIndex].text;
}