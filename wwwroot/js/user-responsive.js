$(document).ready(function(){ 
	var touch 	= $('#resp-user');
	var info_user_responsive 	= $('.info_user_responsive');
 
	$(touch).on('click', function(e) {
		e.preventDefault();
		info_user_responsive.slideToggle();
	});
	
	$(window).resize(function(){
		var w = $(window).width();
		if(w > 810 && info_user_responsive.is(':hidden')) {
			info_user_responsive.removeAttr('style');
		}
	});
	
});