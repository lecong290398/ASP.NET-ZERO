(function () {
    var _personService = abp.services.app.person;


    var _createPersonModal = new app.ModalManager({
        viewUrl: abp.appPath + 'AppAreaLeCong/PhoneBook/CreatePersonModal',
        scriptUrl: abp.appPath + 'view-resources/Areas/AppAreaLeCong/Views/PhoneBook/_CreatePersonModal.js',
        modalClass: 'CreatePersonModal'
    });

    $('#CreateNewPersonButton').click(function (e) {
        e.preventDefault();
        _createPersonModal.open();
    });

    $('#AllPeopleList button.delete-person').click(function (e) {
        debugger;
        e.preventDefault();
    
        var $listItem = $(this).closest('.list-group-item');
        var personId = $listItem.attr('data-person-id');
    
        abp.message.confirm(
            app.localize('AreYouSureToDeleteThePerson'),
            app.localize('AreYouSure'),
            function(isConfirmed) {
                if (isConfirmed) {
                    _personService.deletePerson({
                        id: personId
                    }).done(function () {
                        abp.notify.info(app.localize('SuccessfullyDeleted'));
                        $listItem.remove();
                    });
                }
            }
        );
    });



    //Edit person button
$('#AllPeopleList button.edit-person').click(function (e) {
    e.preventDefault();

    var $listItem = $(this).closest('.list-group-item');

    $listItem
        .toggleClass('person-editing')
        .siblings().removeClass('person-editing');
});

//Save phone button
$('#AllPeopleList .button-save-phone').click(function (e) {
    e.preventDefault();
    debugger;
    var $phoneEditorRow = $(this).closest('tr');

    abp.ajax({
        url: abp.appPath + 'AppAreaLeCong/PhoneBook/AddPhone',
        dataType: 'html',
        data: JSON.stringify({
            personId: $phoneEditorRow.closest('.list-group-item').attr('data-person-id'),
            Type: $phoneEditorRow.find('select[name=Type]').val(),
            Number: $phoneEditorRow.find('input[name=Number]').val()
        })
    }).done(function (result) {
        $(result).insertBefore($phoneEditorRow);
    });
});

//Delete phone button
$('#AllPeopleList').on('click', '.button-delete-phone', function (e) {
    e.preventDefault();

    var $phoneRow = $(this).closest('tr');
    var phoneId = $phoneRow.attr('data-phone-id');

    _personService.deletePhone({
        id: phoneId
    }).done(function () {
        abp.notify.success(app.localize('SuccessfullyDeleted'));
        $phoneRow.remove();
    });
});

var _editPersonModal = new app.ModalManager({
    viewUrl: abp.appPath + 'AppAreaLeCong/PhoneBook/EditPersonModal',
    scriptUrl: abp.appPath + 'view-resources/Areas/AppAreaLeCong/Views/PhoneBook/_EditPersonModal.js',
    modalClass: 'EditPersonModal'
});

$('#AllPeopleList button.edit-person').click(function (e) {
    e.preventDefault();
    var $listItem = $(this).closest('.list-group-item');
    var id = $listItem.data('person-id');
    _editPersonModal.open({ id: id });
});

    
})();
