﻿namespace Aidan.Web;

public static partial class StaticHtml
{
    public static readonly string NotFoundCoolPage = @"<!DOCTYPE html>
<html lang='pt-BR'>

<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>404 - Página Não Encontrada</title>

    <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap"" rel=""stylesheet"">

    <!-- Estilo do background de tema retrô -->
    <style>
        html,
        body {
            margin: 0;
            height: 100%;
        }

        /* ............................................................... */
        /* ............................................................... */
        /* ............................................................... */
        #retrobg {
            position: relative;
            overflow: hidden;
            height: 100%;
            color: #a3c;
            background-color: #000;
        }

        /* ............................................................... */
        #retrobg-sky {
            position: absolute;
            display: flex;
            align-items: flex-end;
            justify-content: center;
            top: 0;
            width: 100%;
            height: 55%;
            background: linear-gradient(#214 75%, #249);
        }

        /* ............................................................... */
        #retrobg-sunWrap {
            position: relative;
            width: 40%;
            margin-bottom: -15%;
        }

        #retrobg-sun {
            --glow-color: #d44;
            padding-top: 100%;
            border-radius: 50%;
            background-image: linear-gradient(#fcdf11, #ff623f, #fe2085 50%);
            box-shadow: 0 0 160px 80px var(--glow-color);
            animation: 2s ease infinite alternate retrobg-sun-glow-anim;
        }

        .retrobg-shutdown #retrobg-sun {
            background-image: linear-gradient(#000, #000 40%);
            --glow-color: #000;
        }

        @keyframes retrobg-sun-glow-anim {
            from {
                box-shadow: 0 0 160px 80px var(--glow-color);
            }

            to {
                box-shadow: 0 0 200px 95px var(--glow-color);
            }
        }

        /* ............................................................... */
        #retrobg-stars {
            position: absolute;
            width: 100%;
            height: 100%;
        }

        .retrobg-star {
            position: absolute;
            border-radius: 50%;
            width: 2px;
            height: 2px;
            background-color: #fff;
        }

        /* ............................................................... */
        #retrobg-mountains {
            position: absolute;
            width: 100%;
            height: 30%;
        }

        .retrobg-mountain {
            position: absolute;
            width: 30%;
            height: 100%;
            background-image: linear-gradient(#000 70%, #111 85%, #fff1);
        }

        #retrobg-mountains-left {
            left: 0;
            clip-path: polygon(0% 100%, 0% 55%, 5% 60%, 10% 55%, 20% 50%, 25% 42%, 30% 38%, 33% 35%, 40% 45%, 50% 50%, 60% 70%, 70% 85%, 75% 82%, 80% 91%, 85% 90%, 90% 95%, 95% 98%, 100% 100%);
        }

        #retrobg-mountains-right {
            right: 0;
            clip-path: polygon(0% 100%, 5% 95%, 10% 85%, 15% 87%, 20% 80%, 25% 78%, 30% 65%, 40% 70%, 50% 57%, 60% 53%, 67% 68%, 70% 70%, 75% 66%, 80% 55%, 90% 50%, 95% 60%, 100% 57%, 100% 100%);
        }

        /* ............................................................... */
        #retrobg-cityWrap {
            position: absolute;
            width: 50%;
            margin-left: -1%;
        }

        #retrobg-city {
            padding-top: 20%;
        }

        .retrobg-building {
            position: absolute;
            width: 5%;
            height: 100%;
            bottom: 0;
            border-radius: 4px 4px 0 0;
            background-image: linear-gradient(0deg, rgba(17, 17, 34, 0), #112 30px, #000);
        }

        .retrobg-building:nth-child(odd) {
            background-image: linear-gradient(0deg, rgba(24, 24, 42, 0), #223 30px, #000);
        }

        .retrobg-antenna::after {
            content: """";
            position: absolute;
            left: 50%;
            margin-left: calc(-1px - 5%);
            bottom: 100%;
            width: 10%;
            min-width: 2px;
            height: 33%;
            background-color: #000;
        }

        /* ............................................................... */
        #retrobg-ground {
            position: absolute;
            overflow: hidden;
            width: 100%;
            height: 45%;
            bottom: 0;
            border-top: 2px solid #bf578c;
            background-color: #000;
        }

        .retrobg-shutdown #retrobg-ground {
            border-color: #000;
        }

        #retrobg-groundShadow {
            position: absolute;
            top: 0;
            width: 100%;
            height: 100%;
            background-image: linear-gradient(#000 0%, transparent);
        }

        /* ............................................................... */
        #retrobg-linesWrap {
            height: 100%;
            perspective: 1000px;
            perspective-origin: center top;
        }

        #retrobg-lines {
            position: absolute;
            width: 100%;
            height: 100%;
            transform-origin: top center;
            animation: 0.35s linear infinite retrobg-lines-anim;
        }

        .retrobg-shutdown #retrobg-lines {
            animation-duration: 5s;
        }

        @keyframes retrobg-lines-anim {
            from {
                transform: rotateX(84deg) translateY(0);
            }

            to {
                transform: rotateX(84deg) translateY(100px);
            }
        }

        #retrobg-hlines,
        #retrobg-vlines {
            position: absolute;
            left: calc((900% - 100%) / -2);
            width: 900%;
            height: 500%;
        }

        #retrobg-vlines {
            display: flex;
            justify-content: center;
        }

        .retrobg-hline,
        .retrobg-vline {
            width: 100%;
            height: 100%;
            background-color: currentColor;
        }

        .retrobg-hline {
            height: 3px;
        }

        .retrobg-vline {
            width: 3px;
        }

        .retrobg-hline+.retrobg-hline {
            margin-top: 98px;
        }

        .retrobg-vline+.retrobg-vline {
            margin-left: 48px;
        }
    </style>

    <!-- Estilo do GIF do John Travolta -->
    <style>
        /* CSS para a página crua com o GIF do John Travolta */

        body,
        h1,
        p {
            margin: 0;
            padding: 0;
        }

        body {
            font-family: 'Roboto', sans-serif;
            background: url('https://source.unsplash.com/random') no-repeat center center fixed;
            background-size: cover;
            position: relative;
            height: 100vh;
            overflow: hidden;
        }

        .john-travolta {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
            z-index: 1;
            padding: 20px;
            box-sizing: border-box;
            max-width: 90%;
        }

        .message {
            color: white;
            display: inline-block;
        }

        .message h1,
        .message p {
            text-shadow:
                0 0 5px #B02060,
                0 0 10px #B02060,
                0 0 15px #FF4C4C,
                0 0 20px #FF4C4C,
                0 0 25px #FF4C4C,
                0 0 30px #7D0E87,
                0 0 35px #7D0E87;
            /* Combinação de Neon Vermelho com Roxo Escuro */
        }

        .message h1 {
            font-size: 56px;
            text-transform: uppercase;
            letter-spacing: 1.5px;
            color: #FFFFFF;
        }

        .message p {
            font-size: 28px;
            /* Ajustado */
        }

        #travolta-gif {
            display: block;
            max-width: 70%;
            /* Ajustado para Desktop */
            width: 100%;
            margin: 15px auto;
        }

        /* Breakpoints */
        @media screen and (max-width: 1200px) {
            .message h1 {
                font-size: 48px;
            }

            .message p {
                font-size: 26px;
                /* Ajustado */
            }

            #travolta-gif {
                max-width: 75%;
            }
        }

        @media screen and (max-width: 800px) {
            .message h1 {
                font-size: 44px;
            }

            .message p {
                font-size: 24px;
                /* Ajustado */
            }

            #travolta-gif {
                max-width: 85%;
                /* Ajustado */
            }
        }

        @media screen and (max-width: 500px) {
            .message h1 {
                font-size: 36px;
            }

            .message p {
                font-size: 22px;
                /* Ajustado */
            }

            #travolta-gif {
                max-width: 95%;
                /* Aumentado para Mobile */
            }
        }
    </style>
</head>

<body>

    <!-- Background de tema retrô  -->
    <div id=""retrobg"">
        <div id=""retrobg-sky"">
            <div id=""retrobg-stars"">
                <div class=""retrobg-star"" style=""left:  5%; top: 55%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left:  7%; top:  5%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 10%; top: 45%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 12%; top: 35%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 15%; top: 39%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 20%; top: 10%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 35%; top: 50%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 40%; top: 16%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 43%; top: 28%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 45%; top: 30%; transform: scale( 3 );""></div>
                <div class=""retrobg-star"" style=""left: 55%; top: 18%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 60%; top: 23%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 62%; top: 44%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 67%; top: 27%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 75%; top: 10%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 80%; top: 25%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 83%; top: 57%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 90%; top: 29%; transform: scale( 2 );""></div>
                <div class=""retrobg-star"" style=""left: 95%; top:  5%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 96%; top: 72%; transform: scale( 1 );""></div>
                <div class=""retrobg-star"" style=""left: 98%; top: 70%; transform: scale( 3 );""></div>
            </div>
            <div id=""retrobg-sunWrap"">
                <div id=""retrobg-sun""></div>
            </div>
            <div id=""retrobg-mountains"">
                <div id=""retrobg-mountains-left"" class=""retrobg-mountain""></div>
                <div id=""retrobg-mountains-right"" class=""retrobg-mountain""></div>
            </div>
            <div id=""retrobg-cityWrap"">
                <div id=""retrobg-city"">
                    <div style=""left:  4.0%; height: 20%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left:  6.0%; height: 50%; width: 1.5%;"" class=""retrobg-building""></div>
                    <div style=""left:  8.0%; height: 25%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 12.0%; height: 30%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 13.0%; height: 55%; width: 3.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 17.0%; height: 20%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 18.5%; height: 70%; width: 1.5%;"" class=""retrobg-building""></div>
                    <div style=""left: 20.0%; height: 30%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 21.5%; height: 80%; width: 2.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 25.0%; height: 60%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 28.0%; height: 40%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 30.0%; height: 70%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 35.0%; height: 65%; width: 4.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 38.0%; height: 40%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 42.0%; height: 60%; width: 2.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 43.0%; height: 85%; width: 4.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 45.0%; height: 40%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 48.0%; height: 25%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 50.0%; height: 80%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 52.0%; height: 32%; width: 5.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 55.0%; height: 55%; width: 3.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 58.0%; height: 45%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 61.0%; height: 90%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 66.0%; height: 99%; width: 4.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 69.0%; height: 30%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 73.5%; height: 90%; width: 2.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 72.0%; height: 70%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 75.0%; height: 60%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 80.0%; height: 40%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 83.0%; height: 70%; width: 4.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 87.0%; height: 60%; width: 3.0%;"" class=""retrobg-building retrobg-antenna""></div>
                    <div style=""left: 93.0%; height: 50%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 91.0%; height: 30%; width: 4.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 94.0%; height: 20%; width: 3.0%;"" class=""retrobg-building""></div>
                    <div style=""left: 98.0%; height: 35%; width: 2.0%;"" class=""retrobg-building""></div>
                </div>
            </div>
        </div>
        <div id=""retrobg-ground"">
            <div id=""retrobg-linesWrap"">
                <div id=""retrobg-lines"">
                    <div id=""retrobg-vlines"">
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                        <div class=""retrobg-vline""></div>
                    </div>
                    <div id=""retrobg-hlines"">
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                        <div class=""retrobg-hline""></div>
                    </div>
                </div>
            </div>
            <div id=""retrobg-groundShadow""></div>
        </div>
    </div>
    <!-- partial -->
    <script>
        document.querySelector(""#retrobg-sun"").onclick = () => {
            document.querySelector(""#retrobg"").classList.toggle(""retrobg-shutdown"");
        };
    </script>

    <!-- GIF do John Travolta  -->
    <div class=""john-travolta"">
        <div class=""message"">
            <h1>Erro 404</h1>
            <p>A página que você está procurando não foi encontrada.</p>
        </div>
        <img src='https://i.imgur.com/qhMbkGi.jpg' alt='John Travolta' id='travolta-gif'>
    </div>

</body>

</html>";
}