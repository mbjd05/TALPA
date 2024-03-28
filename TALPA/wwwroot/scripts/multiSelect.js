$(function () {
    $('#restrictionsInput').select2( {
        theme: "bootstrap-5",
        width: $( this ).data( 'width' ) ? $( this ).data( 'width' ) : $( this ).hasClass( 'w-100' ) ? '100%' : 'style',
        placeholder: $( this ).data( 'placeholder' ),
        closeOnSelect: false,
    });

    $("#suggestionModal").on('hide.bs.modal', function(){
        $('#restrictionsInput').val(null).trigger("change")
        $('#activityInput').val(null).trigger("change")
    });
})