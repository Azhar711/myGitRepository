<div id="SearchBg">
  <div id="Search">
   <form action="/search/index.asp" method="get" name="mysearchTop" id="mysearchTop" onsubmit="return ValidateSearchTop()">
            <label for="SearchBox"></label>
            <input name="SearchString" type="text"  size="20" maxlength="80" alt="Search Box" tabindex="1" id="SearchBox" onclick="javascript:this.value='';" value="Search"/>
       <input name="Action" type="submit" class="SearchButton" onmouseover="this.className='SearchButtonOver'" onfocus="this.className='SearchButtonOver'" onmouseout="this.className='SearchButton'" onblur="this.className='SearchButton'" value="" alt="Search Button" tabindex="2"/>
            <input name="doSearch" type="hidden" id="doSearch" value="1"/>
        </form>
      </div>
    </div>