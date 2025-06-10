using IconMakinator.Exceptions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Tga;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace IconMakinator.Utility
{
    public static class ImageCreator
    {
        public static void ApplyOverlay(Image<Rgba32> baseImage, string overlayPath, float opacity = 1f)
        {
            using var overlay = Image.Load<Rgba32>(overlayPath);
            baseImage.Mutate(i => i.DrawImage(overlay, new Point(0, 0), opacity));
        }

        public static Image<Rgba32> ApplyUnderlay(string backgroundPath, string imagePath)
        {
            var background = Image.Load<Rgba32>(backgroundPath);
            var baseImage = Image.Load<Rgba32>(imagePath);

            background.Mutate(i => i.DrawImage(baseImage, new Point(0, 0), 1f));

            return background;
        }

        public static void SaveAsTga(Image<Rgba32> image, string path)
        {
            image.SaveAsTga(path, new TgaEncoder { BitsPerPixel = TgaBitsPerPixel.Pixel32 });
        }

        public static string SaveAsPng(Image<Rgba32> image, string path)
        {
            image.SaveAsPng(path.Replace(".tga", ".png"), new SixLabors.ImageSharp.Formats.Png.PngEncoder());
            return path.Replace(".tga", ".png");
        }

        public static string AllInOne(string baseImagePath, string? backgroundPath, string overlayPath, string outputPath)
        {
            if (baseImagePath is null || baseImagePath == string.Empty)
                throw new NoImageSelectedException();

            Image<Rgba32> image;
            if (backgroundPath is not null && backgroundPath != string.Empty)
            {
                image = ApplyUnderlay(backgroundPath, baseImagePath);
            }
            else
            {
                image = Image.Load<Rgba32>(baseImagePath);
            }
            ApplyOverlay(image, overlayPath);
            SaveAsTga(image, outputPath);
            return SaveAsPng(image, outputPath);
        }

        //flips the image because Bomber icons are flipped
        public static string BomberSpecific(string baseImagePath, string outputPath)
        {
            var image = Image.Load<Rgba32>(baseImagePath);
            image.Mutate(i => i.Flip(FlipMode.Horizontal));
            SaveAsTga(image, outputPath);
            return SaveAsPng(image, outputPath);
        }

        public static void BasicTga(string baseImagePath, string outputPath)
        {
            SaveAsTga(Image.Load<Rgba32>(baseImagePath), outputPath);
        }
    }
}
