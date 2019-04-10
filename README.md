# Star-Wars-Fights

## FrontEnd

1.	Pantalla de inicio
	a.	Planeta (Default).
	b.	Grilla de personajes x2
	c.	Lucha.
2.	Selección de Planeta. (opcional)
3.	Selección del personaje.
	a.	10 por default
	b.	Filtros
		i.	Genero
		ii.	Especie (Nueva llamada)
4.	Selección de armas.
5.	Selección de habilidades.
6.	Validar conformación del personaje
	a.	Éxito
	b.	Mensaje de error
7.	Luchar
	a.	Resultado
8.	¿? Rematch? New fight? (¿Qué pasa después de la pelea?)



## BackEnd (API)

1.	Servicio personajes **done**
	a.	Tomamos de swapi.co
	b.	Parametros:
		i.	cantidad (obligatorio)
		ii.	género (opcional)
		iii.	especie (opcional)
2.	Servicio Armas. (get) **done**
	a.	Pregeneradas
	b.	IDEA: restringir personajes que las puedan usar
3.	Servicio Habilidades. (get) **done**
	a.	Pregeneradas
	b.	IDEA: restringir personajes que las puedan usar
4.	Servicio de Especies (get) **done**
	a.	Tomamos de swapi.co 
5.	Servicio Planetas. (get) **done**
	a.	Tomamos de swapi.co
	b.	Ver que planetas devolvemos (Elegir)
6.	Servicio de Validacion de armado
7.	Servicio Pelea. (post(Personaje, Armas, Habilidades, Planeta))
	a.	Validar que AMBOS personajes estén bien armados
	b.	Usar reglas para planetas (Inventar)
 

 Para iniciar angular: npm start