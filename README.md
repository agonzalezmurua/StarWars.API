# StarWars.API
API de demo para utilizar en el desafío [React desde cero](https://github.com/cchini/react-desde-cero)

# Aclaración
La API puede que por su naturaleza de demo se encuentre levantada, por ende se referenciará a la URl como API_URL
## Firmas de URL

### Afiliaciones

#### Todas - GET
```ES6
API_URL/api/afiliations/
```

#### Gente por afiliación - GET
```ES6
API_URL/api/{afiliacion}/people
```

#### Planetas por afiliación - GET
```ES6
API_URL/api/{afiliacion}/planets
```

### Personas

#### Todas - GET
```ES6
API_URL/api/people
```

#### Persona en particular - GET
```ES6
API_URL/api/people/{id}
```

### Ocupaciones

#### Todas - GET
```ES6
API_URL/api/occupation
```

#### Personas por ocupación - GET
```ES6
API_URL/api/{occupation}/people
```

### Planetas

#### Todos - GET
```ES6
API_URL/api/planets
```

#### Planeta en particular - GET
```ES6
API_URL/api/planets{id}
```

#### Personas por planeta natal
```ES6
API_URL/api/planets/{id}/people
```
