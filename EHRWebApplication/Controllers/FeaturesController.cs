using EHRWebApplication.Models;
using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    [Utils.Administrador]
    public class FeaturesController : MainController
    {
        // GET: Features
        public ActionResult Index()
        {
            var features = FeatureBLL.GetFeatures()
                .Select(l => new FeatureViewModel
                {
                    Id = l.Id,
                    Feature = l.Name,
                    Description = l.Description,
                    CreatedAt = l.CreatedAt,
                    TemplateName = l.OperationalsTemplate.Name,
                    DisplayMenu = l.DisplayMenu,
                    DisplayMenuLabel = l.DisplayMenu == 1 ? "Sim" : "Não",
                    Status = l.status,
                    StatusLabel = l.status == 1 ? "Ativo" : "Inativo",
                    RoleGroup = l.FeatureGroups.FirstOrDefault(f => f.FeatureID == l.Id).RolesGroup.Id,
                    RoleGroupLabel = RolesDictionary.getValue(
                                                        (short)l.FeatureGroups
                                                                .FirstOrDefault(f => f.FeatureID == l.Id)
                                                                .RolesGroup.Id)
                });

            return View(features);
        }

        // GET: Features/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Features/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Features/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Features/Edit/5
        public ActionResult Edit(int id)
        {
            var feature = FeatureBLL.GetFeatureById(id);

            if (feature == null)
            {
                return HttpNotFound();
            }

            var editFeature = new EditFeatureViewModel();
            
            if (feature != null)
            {
                editFeature.Id = feature.Id;
                editFeature.Feature = feature.Name;
                editFeature.Description = feature.Description;
                editFeature.DisplayMenu = feature.DisplayMenu;
                editFeature.RoleGroup = feature.FeatureGroups.FirstOrDefault(f => f.FeatureID == feature.Id).RoleGroupID;
                editFeature.Status = feature.status;
            }

            return View(editFeature);
        }

        // POST: Features/Edit/5
        [HttpPost]
        public ActionResult Edit(EditFeatureViewModel editFeature)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var feature = new Feature();

                    feature.Id = editFeature.Id;
                    feature.Name = editFeature.Feature;
                    feature.Description = editFeature.Description;
                    feature.DisplayMenu = editFeature.DisplayMenu;
                    feature.status = editFeature.Status;
                    feature.UserId = (int)Session["Id"];

                    var updated = FeatureBLL.UpdateFeature(feature, editFeature.RoleGroup);

                    if (updated)
                    {
                        return RedirectToAction("Details", new { id = feature.Id });
                    }
                }

                return View(editFeature);
            }
            catch
            {
                return View();
            }
        }

        // GET: Features/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Features/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
