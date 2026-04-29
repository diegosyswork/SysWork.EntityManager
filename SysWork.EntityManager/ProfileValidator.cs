using FluentValidation;
using System;
using System.IO;
using SysWork.Data.Common.ValueObjects;
using SysWork.EntityManager.Data;

namespace SysWork.EntityManager
{
    public class ProfileValidator: AbstractValidator<Profile>
    {
        public ProfileValidator()
        { 
            RuleSet("ProfileName", () =>
            {
                RuleFor(parameter => parameter.ProfileName)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Debe informar el nombre del Perfil")
                    .NotNull().WithMessage("El nombre del Perfil no puede ser NULL");
            });

            RuleSet("DatabaseEngine", () =>
            {
                RuleFor(parameter => parameter.DatabaseEngine)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("Debe informar el motor de base de datos")
                    .NotEmpty().WithMessage("Debe informar el motor de base de datos")
                    .Must(IsValidDatabaseEngine);
                
            });
            
            RuleSet("ConnectionString", () =>
            {
                RuleFor(parameter => parameter.ConnectionString)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("La cadena de conexion no puede ser NULL")
                    .NotEmpty().WithMessage("La cadena de conexion no puede estar vacia");
            });
            
            RuleSet("Namespace", () =>
            {
                RuleFor(parameter => parameter.Namespace)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("El Namespace predeterminado no puede ser NULL")
                    .NotEmpty().WithMessage("El Namespace predeterminado no puede estar vacio");
            });
            
            RuleSet("EntitiesDirectory", () => 
            {
                When(parameter => (parameter.CreateEntity== true), () =>
                {
                    RuleFor(parameter => parameter.EntitiesDirectory)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("El directorio de entidades no puede ser NULL")
                    .NotEmpty().WithMessage("El directorio de entidades no puede estar vacio")
                    .Must(ExistsFolder).WithMessage("El directorio de entidades no existe");
                });
            });

            RuleSet("RepositoriesDirectory", () =>
            {
                When(p => (p.CreateRepository == true),() =>
                {
                    RuleFor(parameter => parameter.RepositoriesDirectory)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("El directorio de repositorios no puede ser NULL")
                    .NotEmpty().WithMessage("El directorio de repositorios no puede estar vacio")
                    .Must(ExistsFolder).WithMessage("El directorio de repositorios no existe");
                });
            });

            RuleSet("DataManagerDirectory", () =>
            {
                When(p => (p.CreateDataManager == true), () =>
                {
                    RuleFor(parameter => parameter.DataManagerDirectory)
                    .Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("El directorio del DataManager no puede ser NULL")
                    .NotEmpty().WithMessage("El directorio del DataManager no puede estar vacio")
                    .Must(ExistsFolder).WithMessage("El directorio de repositorios no existe");
                });
            });
            
            RuleSet("ProfileSelectedObject", () =>
            {
                RuleFor(parameter => parameter.ProfileSelectedObjects)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("La lista de objetos seleccionados no puede ser null.")
                .Must(parameter => parameter.Count > 0).WithMessage("Debe seleccionar al menos un objeto.");
            });

            RuleSet("CreateEntity", () =>
            {
                RuleFor(e => e.CreateEntity)
                .Must(IsTrue)
                .When(p => ((p.CreateRepository==false) && (p.CreateDataManager=false)))
                .WithMessage("Debe seleccionar CreateEntity si no selecciono CreateRepository ni CreateDatamanager");
            });
            
            RuleSet("CreateRepository", () =>
            {
                RuleFor(e => e.CreateRepository)
                .Must(IsTrue)
                .When(p => ((p.CreateEntity==false) && (p.CreateDataManager==false)))
                .WithMessage("Debe seleccionar CreateRepository si no selecciono CreateEntity ni CreateDatamanager");
            });
            
            RuleSet("CreateDataManager", () =>
            {
                RuleFor(e => e.CreateDataManager)
                .Must(IsTrue)
                .When(p => ((p.CreateEntity==false) && (p.CreateDataManager==false)))
                .WithMessage("Debe seleccionar CreateDatamanager si no selecciono CreateEntity ni CreateRepository");
            });

            RuleSet("CheckCreateSomeObject", () =>
            {
                When(p => (!p.CreateDataManager && !p.CreateEntity && !p.CreateRepository ), () =>
                {
                    RuleFor(parameter => parameter.CreateEntity)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Debe seleccionar si crea al menos Entidades, Repositorios o el DataManager");
                });
            });
        }

        private bool IsValidDatabaseEngine(string databaseEngine)
        {
            return (Enum.TryParse<EDatabaseEngine>(databaseEngine, true,out EDatabaseEngine resultDatabaseEngine));
        }

        private bool IsTrue(bool @value)
        {
            return @value == true;
        }

        private bool ExistsFolder(string folder)
        {
            return Directory.Exists(folder);
        }
    }
}
