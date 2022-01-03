// $('.galeria').slick({ 
//   slidesToShow: 4,
//   slidesToScroll: 3,
// });
$('.galeria').slick({
    centerMode: true,
    centerPadding: '50px',
    slidesToShow: 4,
    responsive: [
      {
        breakpoint: 768,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 3
        }
      },
      {
        breakpoint: 480,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 1
        }
      }
    ]
  });
  