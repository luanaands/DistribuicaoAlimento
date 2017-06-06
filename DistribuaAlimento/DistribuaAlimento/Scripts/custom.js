function ExibirNotificacaoErro(notificacoes) {
    toastr.remove()
        $.each(notificacoes, function (i, notificacao) {
            if (notificacao!="") {
                toastr.error(notificacao, 'Atenção', {
                title: 'Atenção',
                message: notificacao,
                priority: 'danger',
                closeButton: true,
                debug: false,
                newestOnTop: false,
                progressBar: false,
                positionClass: "toast-top-right", //"toast-top-center",
                preventDuplicates: false,
                onclick: null,
                showDuration: 300,
                hideDuration: 1000,
                timeOut: 5000,
                extendedTimeOut: 1000,
                showEasing: "swing",
                hideEasing: "linear",
                showMethod: "fadeIn",
                hideMethod: "fadeOut"
            });
            }
        });
}

function ExibirNotificacaoInfo(notificacoes) {
    toastr.remove()

    $.each(notificacoes, function (i, notificacao) {
        toastr.error(notificacao, 'Atenção', {
            title: 'Atenção',
            message: notificacao,
            priority: 'info',
            closeButton: true,
            debug: false,
            newestOnTop: false,
            progressBar: false,
            positionClass: "toast-top-right",
            preventDuplicates: false,
            onclick: null,
            showDuration: 300,
            hideDuration: 1000,
            timeOut: 5000,
            extendedTimeOut: 1000,
            showEasing: "swing",
            hideEasing: "linear",
            showMethod: "fadeIn",
            hideMethod: "fadeOut"
        });
    });
}

function ExibirNotificacaoSucesso2(notificacoes) {
    alert(notificacoes);
}


function ExibirNotificacaoSucesso(notificacoes) {
    toastr.remove()

    $.each(notificacoes, function (i, notificacao) {
        toastr.success(notificacao, 'Atenção', {
            //title: 'Atenção',
            message: notificacao,
            priority: 'success',
            closeButton: true,
            debug: false,
            newestOnTop: false,
            progressBar: false,
            positionClass: "toast-top-right",
            preventDuplicates: false,
            onclick: null,
            showDuration: 300,
            hideDuration: 1000,
            timeOut: 5000,
            extendedTimeOut: 1000,
            showEasing: "swing",
            hideEasing: "linear",
            showMethod: "fadeIn",
            hideMethod: "fadeOut"
        });
    });

}

function ExibirNotificacaoAtencao(notificacoes) {
    toastr.remove()

    $.each(notificacoes, function (i, notificacao) {
        toastr.warning(notificacao, 'Atenção', {
            //title: 'Atenção',
            message: notificacao,
            priority: 'warning',
            closeButton: true,
            debug: false,
            newestOnTop: false,
            progressBar: false,
            positionClass: "toast-top-center",
            preventDuplicates: false,
            onclick: null,
            showDuration: 300,
            hideDuration: 1000,
            timeOut: 5000,
            extendedTimeOut: 1000,
            showEasing: "swing",
            hideEasing: "linear",
            showMethod: "fadeIn",
            hideMethod: "fadeOut"
        });
    });
}

function chkSDSelecionarTodos(chkboxName, statusId) {
    $(".chkSD-" + statusId).prop("checked", $("#" + chkboxName).prop("checked"));
}
