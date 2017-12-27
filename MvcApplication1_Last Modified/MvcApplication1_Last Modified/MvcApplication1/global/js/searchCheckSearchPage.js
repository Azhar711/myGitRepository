// VALIDATE THE FORM
function ValidateSearchPage() {
    document.SearchPage.SearchString.className = 'SearchPageField'

// VALIDATE SEARCH
  if (document.SearchPage.SearchString.value=="" || isWhitespace(document.SearchPage.SearchString.value)==true)
  {
    document.SearchPage.SearchString.className = 'SearchPageFieldRequired'
    alert("Search can not be blank.  Please enter a search term.")
    document.SearchPage.SearchString.focus()
    return false
  }

}

