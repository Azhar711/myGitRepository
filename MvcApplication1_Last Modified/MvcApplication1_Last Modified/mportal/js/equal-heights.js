 $(document).ready(function(){
 
 function setEqualHeight(selector, triggerOnInput) {
    	var elements = $(selector)
    	elements.css("height", "auto")
    	var max = Number.NEGATIVE_INFINITY;
    	$.each(elements, function(index, item) {
    		if ($(item).height() > max) {
    			max = $(item).height()
    		}
    	})
    	$(selector).css("height", max + "px")
    
    	if (!!triggerOnInput) {
    		$(document).on("input", selector, function() {
    			setEqualHeight(selector, false)
    
    		})
    	}
    
    	$(window).resize(function() {
    		setEqualHeight(selector, false)
    	})
    }
        
        setEqualHeight(".providerList .provider", true) 
		
});