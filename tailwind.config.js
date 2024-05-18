module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    theme: {
        extend: {
            screens: {
                sm: "480px",
                md: "768px",
                lg: "976px",
                xl: "1440px",
                "2xl": "1536px",
            },
            colors: {
                primary: "#583900",
                "light-green": "#04FFB4",
                "light-blue": "#04C3FF",
                red: "#FF0000",
                "darker-red": "#D2042D",
            },
            backgroundColor: {
                orange: "#FFA500",
                "light-green": "#04FFB4",
                "light-blue": "#04C3FF",
            },
            aspectRatio: {
                "752/444": "752/444",
            }
        }
    },
    plugins: [],
}