function initModal() {
	$('.modal').on('show.bs.modal', function (e) {
	});

	///
	/// Vang de hide op om de inhoud van de modal te wissen
	$('.modal').on('hide.bs.modal', function (e) {
		CleanModal();
	});
}

function OpenCreateDialog() {
	//HideProgress();
	CleanModal();
	$("#modalPopUp").modal('show');
}

function CleanModal() {
	$("#ModalContent").html("Loading...");
	//$("#CreateItemContent").html("even geduld aub...");
}