-- Procedimiento almacenado para actualizar registros de unidades XR90
CREATE PROCEDURE ActualizarRegistrosXR90
	@ClaveUnidad INT
AS
BEGIN
    -- Eliminar registros antiguos de la unidad XR90
    DELETE FROM Tabla_registros
    WHERE ClaveUnidad = @ClaveUnidad

    -- Insertar nuevos registros para la unidad XR90
    INSERT INTO Tabla_registros (
	ClaveUnidad,
	NumeroModulo,
	NumeroModulosUnidad,
	FechaCreacion,
	FechaActualizacion
	)
    VALUES
        (@ClaveUnidad, 1, (SELECT COUNT(*) FROM Tabla_registros WHERE ClaveUnidad = @ClaveUnidad), GETDATE(), GETDATE()),
        (@ClaveUnidad, 2, (SELECT COUNT(*) FROM Tabla_registros WHERE ClaveUnidad = @ClaveUnidad), GETDATE(), GETDATE()),
        (@ClaveUnidad, 3, (SELECT COUNT(*) FROM Tabla_registros WHERE ClaveUnidad = @ClaveUnidad), GETDATE(), GETDATE())
END