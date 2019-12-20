/// <reference path="../lib/razor/raz.js"/>

function movieListTemplateRender() {

    let template = async function () {
        return await new Promise((resolve) => {

            var temp = `
            <div>
            @{
                // For Testing Purpose
                var temp="Kishor Naik";
                console.log(temp);
                console.log(new Date().getFullYear());


            }
            </div>
            

            @for(var i = 0; i < Model.length; i++)
            {
                // Extract Data
                var movieModel=Model[i];

                // Make View Url
                var viewUrl='/Movie/OnView/' + movieModel.id;

                <div id='divCart' class='col-lg-4 col-xl-4 col-md-4 col-sm-4 d-flex align-items-stretch'>

                    <div class='card m-3'>

                        <img class='card-img-top' src='@movieModel.url'>

                        <div style='background-color:black; height:40px'>
                            <center>
                                <h5 class='card-title' style='color:white;line-height:40px'>
                                    @movieModel.title
                                </h5>
                            </center>
                        </div>

                        <div class='card-body'>
                            <p class='card-text'>
                                @movieModel.details
                            </p>

                        </div>

                       
                            <a class='btn btn-primary' href="@viewUrl">View</a>
                       
                    </div>

                   
                        

                </div>
            }
            
            `;

            return resolve(temp);

        });
    }

    this.templateRender = async function (listMovie) {
        return await new Promise(async (resolve) => {

            console.log(listMovie);

            // Get a template
            let movieTemplateHtml = await template();
            console.log(movieTemplateHtml);

            // render HTML
            const movieTemplateRender = raz.render(movieTemplateHtml, listMovie);
            console.log(movieTemplateRender);

            $("#divMovieList").append(movieTemplateRender);


            return resolve("Movie Template Render in browser");

        });
    }
}