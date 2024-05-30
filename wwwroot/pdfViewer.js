window.pdfViewer = {
    loadPdf: function (url, canvasContainerId) {
        var loadingTask = pdfjsLib.getDocument(url);
        loadingTask.promise.then(function(pdf) {
            // Get the canvas container element
            var canvasContainer = document.getElementById(canvasContainerId);
            canvasContainer.innerHTML = ''; // Clear any existing content

            // Loop through each page and render it
            for (let pageNumber = 1; pageNumber <= pdf.numPages; pageNumber++) {
                // Create a new canvas element for each page
                let canvas = document.createElement('canvas');
                canvas.id = `pdfCanvas_${pageNumber}`;
                canvasContainer.appendChild(canvas);

                // Render the page
                pdf.getPage(pageNumber).then(function(page) {
                    var scale = 1.5;
                    var viewport = page.getViewport({ scale: scale });

                    // Prepare canvas using PDF page dimensions
                    var context = canvas.getContext('2d');
                    canvas.height = viewport.height;
                    canvas.width = viewport.width;

                    // Render PDF page into canvas context
                    var renderContext = {
                        canvasContext: context,
                        viewport: viewport
                    };
                    page.render(renderContext);
                });
            }
        });
    }
};
