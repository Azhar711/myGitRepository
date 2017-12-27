//Top Search 
// VALIDATE THE FORM
function ValidateSearchTop() {
    //document.mysearchTop.SearchString.className = 'FormRequiredField'

// VALIDATE SEARCH
  if (document.mysearchTop.SearchString.value=="" || isWhitespace(document.mysearchTop.SearchString.value)==true) {
    //document.mysearchTop.SearchString.className = 'FormRequiredField'
    alert("Search can not be blank.  Please enter a search term.")
    document.mysearchTop.SearchString.focus()
    return false
  }

}

