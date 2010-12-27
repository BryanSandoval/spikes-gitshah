package com.dopdf.creator;

import com.lowagie.text.DocumentException;
import org.xhtmlrenderer.pdf.ITextRenderer;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;


public class PDFCreator {

    /**
     * This method creates the pdf,
     *  from the url to the html document passed as argument.
     *  @param url the url of the html document that
     *  needs to be converted into pdf. 
     *  This could be of this format
     *  http://localhost:8080/yourapplication/url_of_the_html_invoice
     */
    public void create(final String url) {
        try {

            /** Creating an instance of iText renderer
             * which will be used to generate the pdf from the
             * html document.
             */
            final ITextRenderer iTextRenderer = new ITextRenderer();

            /**
             * Setting the document as the url value passed.
             * This means that the iText renderer
             * has to parse this html document to generate the pdf.
             */
            iTextRenderer.setDocument(url);
            iTextRenderer.layout();

            /** The generated pdf will be written
             to the invoice.pdf file. */
            final FileOutputStream fileOutputStream =
                    new FileOutputStream(new File("somepdf.pdf"));

            /** Creating the pdf and
             writing it in invoice.pdf file. */
            iTextRenderer.createPDF(fileOutputStream);
            fileOutputStream.close();

        } catch (final DocumentException e) {
            e.printStackTrace();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
