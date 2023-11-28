$(document).ready(function () {
    loop_news_slider();
    $('a.page-submit').on('click', function () {
        var index = $(this).data('index');
        $("#hfCurrentPageIndex").val(index);
        $("#pagination-form").submit();
    });
})

var loop_news_slider_timer = '';

function loop_news_slider() {
    if (loop_news_slider_timer != '') {
        clearTimeout(loop_news_slider_timer);
    }

    var findCurrentSlider = parseInt($('.news-items .news-item.active').index());
    var findTotalSlider = $('.news-items .news-item').length;
    findCurrentSlider += 1;

    if (findCurrentSlider == findTotalSlider) {
        findCurrentSlider = 0;
    }

    $('.news-items .news-item.active').removeClass('active');
    $('.news-items .news-item:nth-child(' + (findCurrentSlider + 1) + ')').addClass('active');

    loop_news_slider_timer = setTimeout(function () {
        loop_news_slider();
    }, 8000);
}

function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}
