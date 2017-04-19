#include "/usr/include/cairo/cairo.h"

int
main (int argc, char *argv[])
{
        cairo_surface_t *surface = 
            cairo_image_surface_create (CAIRO_FORMAT_ARGB32, 12, 23);
        cairo_t *cr = 
            cairo_create (surface);

        cairo_set_source_rgba(cr, 0.05, 0.09, 0.13, 0.8);
        cairo_line_to(cr, 12, 23);
        cairo_close_path (cr);

        cairo_fill_preserve (cr);
        cairo_set_source_rgba(cr, 0.05, 0.09, 0.13, 0.8);
        cairo_stroke (cr);

        cairo_surface_write_to_png (surface, "lol.png");
        cairo_destroy (cr);
        cairo_surface_destroy (surface);

        return 0;
}
