/// <reference path="../lib/razor/raz.js"/>

function movieDisplayTemplateRender() {

    // private Method
    let template = async function () {
        return await new Promise((resolve) => {

            var temp = `

            <div id='divCart' class='col-12 align-items-stretch'>
                <div class='card m-3'>

                    <img class='card-img-top' src='@Model.url'>

                    <div style='background-color:black; height:40px'>
                        <center>
                            <h5 class='card-title' style='color:white;line-height:40px'>
                                @Model.title
                            </h5>
                        </center>
                    </div>

                    <div class='card-body'>
                        <p class='card-text'>
                            @Model.details
                        </p>

                    </div>
                </div>
            </div>
            
            `;

            return resolve(temp);

        });
    }

    // Public Method
    this.templateRender = async function (movie) {
        return await new Promise(async (resolve) => {

            let movieTemplateHtml = await template();

            let movieTemplateRender = raz.render(movieTemplateHtml, movie);

            $("#divDisplayMovie").append(movieTemplateRender);

            return resolve("Movie Data Display");

        });
    }

}