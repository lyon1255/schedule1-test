using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x0200071E RID: 1822
	public class ConstructionMenu : Singleton<ConstructionMenu>
	{
		// Token: 0x0600A3CF RID: 41935 RVA: 0x00291410 File Offset: 0x0028F610
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionMenu()
		{
			Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "ConstructionMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr);
			ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<isOpen>k__BackingField");
			ConstructionMenu.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categories");
			ConstructionMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "canvas");
			ConstructionMenu.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "raycaster");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryNameDisplay");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_ConstructableName");
			ConstructionMenu.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "eventSystem");
			ConstructionMenu.NativeFieldInfoPtr_destroyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "destroyButton");
			ConstructionMenu.NativeFieldInfoPtr_customizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "customizeButton");
			ConstructionMenu.NativeFieldInfoPtr_moveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "moveButton");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_Description");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonPrefab");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainerPrefab");
			ConstructionMenu.NativeFieldInfoPtr_listingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingPrefab");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_selectedCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedCategory");
			ConstructionMenu.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedListing");
			ConstructionMenu.NativeFieldInfoPtr_selectedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedConstructable");
			ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683321);
			ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683322);
			ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683323);
			ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683324);
			ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683325);
			ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683326);
			ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683327);
			ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683328);
			ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683329);
			ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683330);
			ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683331);
			ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683332);
			ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683333);
			ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683334);
			ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683335);
			ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683336);
			ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683337);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683338);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683339);
			ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683340);
			ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683341);
			ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683342);
			ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683343);
			ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683344);
			ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683345);
			ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683346);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683347);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683348);
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A3D0 RID: 41936 RVA: 0x00291850 File Offset: 0x0028FA50
		// (set) Token: 0x0600A3D1 RID: 41937 RVA: 0x0029188C File Offset: 0x0028FA8C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A3D2 RID: 41938 RVA: 0x002918CC File Offset: 0x0028FACC
		public unsafe Constructable SelectedConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
			}
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x0029190C File Offset: 0x0028FB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286564, XrefRangeEnd = 286661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x00291948 File Offset: 0x0028FB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286661, XrefRangeEnd = 286666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x0029198C File Offset: 0x0028FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286666, XrefRangeEnd = 286667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x002919C8 File Offset: 0x0028FBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286667, XrefRangeEnd = 286672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x002919FC File Offset: 0x0028FBFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286715, RefRangeEnd = 286717, XrefRangeStart = 286672, XrefRangeEnd = 286715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListing(string ID, float price, string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x00291A60 File Offset: 0x0028FC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286734, RefRangeEnd = 286735, XrefRangeStart = 286717, XrefRangeEnd = 286734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x00291AA0 File Offset: 0x0028FCA0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConstructableBuilt(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x00291AE4 File Offset: 0x0028FCE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 286742, RefRangeEnd = 286748, XrefRangeStart = 286735, XrefRangeEnd = 286742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelectedListing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x00291B18 File Offset: 0x0028FD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286748, XrefRangeEnd = 286757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingClicked(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x00291B5C File Offset: 0x0028FD5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286769, RefRangeEnd = 286771, XrefRangeStart = 286757, XrefRangeEnd = 286769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x00291B98 File Offset: 0x0028FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286771, XrefRangeEnd = 286785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x00291BCC File Offset: 0x0028FDCC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomizeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x00291C00 File Offset: 0x0028FE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286785, XrefRangeEnd = 286792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulldozeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x00291C34 File Offset: 0x0028FE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286832, RefRangeEnd = 286833, XrefRangeStart = 286792, XrefRangeEnd = 286832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConstructableSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x00291C68 File Offset: 0x0028FE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286833, XrefRangeEnd = 286834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x00291CAC File Offset: 0x0028FEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286909, RefRangeEnd = 286910, XrefRangeStart = 286834, XrefRangeEnd = 286909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c, bool focusCameraTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusCameraTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x00291CFC File Offset: 0x0028FEFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286918, RefRangeEnd = 286920, XrefRangeStart = 286910, XrefRangeEnd = 286918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonInteractable(Button b, bool interactable, Color32 iconDefaultColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iconDefaultColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x00291D5C File Offset: 0x0028FF5C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 286935, RefRangeEnd = 286943, XrefRangeStart = 286920, XrefRangeEnd = 286935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x00291D90 File Offset: 0x0028FF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286943, XrefRangeEnd = 286953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x00291DD0 File Offset: 0x0028FFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287016, RefRangeEnd = 287017, XrefRangeStart = 286953, XrefRangeEnd = 287016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateCategories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x00291E04 File Offset: 0x00290004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287052, RefRangeEnd = 287054, XrefRangeStart = 287017, XrefRangeEnd = 287052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x00291E48 File Offset: 0x00290048
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287073, RefRangeEnd = 287077, XrefRangeStart = 287054, XrefRangeEnd = 287073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetListingPrice(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A3E9 RID: 41961 RVA: 0x00291E98 File Offset: 0x00290098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287077, XrefRangeEnd = 287087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x00291ED4 File Offset: 0x002900D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287087, XrefRangeEnd = 287088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x00291F08 File Offset: 0x00290108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287088, XrefRangeEnd = 287099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x00050B15 File Offset: 0x0004ED15
		public ConstructionMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x00291F3C File Offset: 0x0029013C
		// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x00050B1E File Offset: 0x0004ED1E
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x00291F64 File Offset: 0x00290164
		// (set) Token: 0x0600A3F0 RID: 41968 RVA: 0x00050B39 File Offset: 0x0004ED39
		public unsafe List<ConstructionMenu.ConstructionMenuCategory> categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x00291F94 File Offset: 0x00290194
		// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x00050B58 File Offset: 0x0004ED58
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x00291FC4 File Offset: 0x002901C4
		// (set) Token: 0x0600A3F4 RID: 41972 RVA: 0x00050B77 File Offset: 0x0004ED77
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x00291FF4 File Offset: 0x002901F4
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00050B96 File Offset: 0x0004ED96
		public unsafe Transform categoryButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x00292024 File Offset: 0x00290224
		// (set) Token: 0x0600A3F8 RID: 41976 RVA: 0x00050BB5 File Offset: 0x0004EDB5
		public unsafe RectTransform categoryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x00292054 File Offset: 0x00290254
		// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x00050BD4 File Offset: 0x0004EDD4
		public unsafe Text categoryNameDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A3FB RID: 41979 RVA: 0x00292084 File Offset: 0x00290284
		// (set) Token: 0x0600A3FC RID: 41980 RVA: 0x00050BF3 File Offset: 0x0004EDF3
		public unsafe RectTransform infoPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x002920B4 File Offset: 0x002902B4
		// (set) Token: 0x0600A3FE RID: 41982 RVA: 0x00050C12 File Offset: 0x0004EE12
		public unsafe TextMeshProUGUI infoPopup_ConstructableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x002920E4 File Offset: 0x002902E4
		// (set) Token: 0x0600A400 RID: 41984 RVA: 0x00050C31 File Offset: 0x0004EE31
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A401 RID: 41985 RVA: 0x00292114 File Offset: 0x00290314
		// (set) Token: 0x0600A402 RID: 41986 RVA: 0x00050C50 File Offset: 0x0004EE50
		public unsafe Button destroyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x00292144 File Offset: 0x00290344
		// (set) Token: 0x0600A404 RID: 41988 RVA: 0x00050C6F File Offset: 0x0004EE6F
		public unsafe Button customizeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x00292174 File Offset: 0x00290374
		// (set) Token: 0x0600A406 RID: 41990 RVA: 0x00050C8E File Offset: 0x0004EE8E
		public unsafe Button moveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x002921A4 File Offset: 0x002903A4
		// (set) Token: 0x0600A408 RID: 41992 RVA: 0x00050CAD File Offset: 0x0004EEAD
		public unsafe TextMeshProUGUI infoPopup_Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A409 RID: 41993 RVA: 0x002921D4 File Offset: 0x002903D4
		// (set) Token: 0x0600A40A RID: 41994 RVA: 0x00050CCC File Offset: 0x0004EECC
		public unsafe GameObject categoryButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x00292204 File Offset: 0x00290404
		// (set) Token: 0x0600A40C RID: 41996 RVA: 0x00050CEB File Offset: 0x0004EEEB
		public unsafe GameObject categoryContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A40D RID: 41997 RVA: 0x00292234 File Offset: 0x00290434
		// (set) Token: 0x0600A40E RID: 41998 RVA: 0x00050D0A File Offset: 0x0004EF0A
		public unsafe GameObject listingPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A40F RID: 41999 RVA: 0x00292264 File Offset: 0x00290464
		// (set) Token: 0x0600A410 RID: 42000 RVA: 0x00050D29 File Offset: 0x0004EF29
		public unsafe Color iconColor_Unselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected)) = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x0029228C File Offset: 0x0029048C
		// (set) Token: 0x0600A412 RID: 42002 RVA: 0x00050D44 File Offset: 0x0004EF44
		public unsafe Color iconColor_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected)) = value;
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A413 RID: 42003 RVA: 0x002922B4 File Offset: 0x002904B4
		// (set) Token: 0x0600A414 RID: 42004 RVA: 0x00050D5F File Offset: 0x0004EF5F
		public unsafe Color listingOutlineColor_Unselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected)) = value;
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x002922DC File Offset: 0x002904DC
		// (set) Token: 0x0600A416 RID: 42006 RVA: 0x00050D7A File Offset: 0x0004EF7A
		public unsafe Color listingOutlineColor_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected)) = value;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A417 RID: 42007 RVA: 0x00292304 File Offset: 0x00290504
		// (set) Token: 0x0600A418 RID: 42008 RVA: 0x00050D95 File Offset: 0x0004EF95
		public unsafe ConstructionMenu.ConstructionMenuCategory selectedCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x00292334 File Offset: 0x00290534
		// (set) Token: 0x0600A41A RID: 42010 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		public unsafe ConstructionMenu.ConstructionMenuListing selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A41B RID: 42011 RVA: 0x00292364 File Offset: 0x00290564
		// (set) Token: 0x0600A41C RID: 42012 RVA: 0x00050DD3 File Offset: 0x0004EFD3
		public unsafe Constructable selectedConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DD4 RID: 28116
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006DD5 RID: 28117
		private static readonly IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x04006DD6 RID: 28118
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006DD7 RID: 28119
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006DD8 RID: 28120
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtonContainer;

		// Token: 0x04006DD9 RID: 28121
		private static readonly IntPtr NativeFieldInfoPtr_categoryContainer;

		// Token: 0x04006DDA RID: 28122
		private static readonly IntPtr NativeFieldInfoPtr_categoryNameDisplay;

		// Token: 0x04006DDB RID: 28123
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup;

		// Token: 0x04006DDC RID: 28124
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup_ConstructableName;

		// Token: 0x04006DDD RID: 28125
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006DDE RID: 28126
		private static readonly IntPtr NativeFieldInfoPtr_destroyButton;

		// Token: 0x04006DDF RID: 28127
		private static readonly IntPtr NativeFieldInfoPtr_customizeButton;

		// Token: 0x04006DE0 RID: 28128
		private static readonly IntPtr NativeFieldInfoPtr_moveButton;

		// Token: 0x04006DE1 RID: 28129
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup_Description;

		// Token: 0x04006DE2 RID: 28130
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtonPrefab;

		// Token: 0x04006DE3 RID: 28131
		private static readonly IntPtr NativeFieldInfoPtr_categoryContainerPrefab;

		// Token: 0x04006DE4 RID: 28132
		private static readonly IntPtr NativeFieldInfoPtr_listingPrefab;

		// Token: 0x04006DE5 RID: 28133
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Unselected;

		// Token: 0x04006DE6 RID: 28134
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Selected;

		// Token: 0x04006DE7 RID: 28135
		private static readonly IntPtr NativeFieldInfoPtr_listingOutlineColor_Unselected;

		// Token: 0x04006DE8 RID: 28136
		private static readonly IntPtr NativeFieldInfoPtr_listingOutlineColor_Selected;

		// Token: 0x04006DE9 RID: 28137
		private static readonly IntPtr NativeFieldInfoPtr_selectedCategory;

		// Token: 0x04006DEA RID: 28138
		private static readonly IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04006DEB RID: 28139
		private static readonly IntPtr NativeFieldInfoPtr_selectedConstructable;

		// Token: 0x04006DEC RID: 28140
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006DED RID: 28141
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006DEE RID: 28142
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0;

		// Token: 0x04006DEF RID: 28143
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006DF0 RID: 28144
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006DF1 RID: 28145
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006DF2 RID: 28146
		private static readonly IntPtr NativeMethodInfoPtr_SetupListings_Private_Void_0;

		// Token: 0x04006DF3 RID: 28147
		private static readonly IntPtr NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0;

		// Token: 0x04006DF4 RID: 28148
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0;

		// Token: 0x04006DF5 RID: 28149
		private static readonly IntPtr NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0;

		// Token: 0x04006DF6 RID: 28150
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0;

		// Token: 0x04006DF7 RID: 28151
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04006DF8 RID: 28152
		private static readonly IntPtr NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0;

		// Token: 0x04006DF9 RID: 28153
		private static readonly IntPtr NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0;

		// Token: 0x04006DFA RID: 28154
		private static readonly IntPtr NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0;

		// Token: 0x04006DFB RID: 28155
		private static readonly IntPtr NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0;

		// Token: 0x04006DFC RID: 28156
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0;

		// Token: 0x04006DFD RID: 28157
		private static readonly IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0;

		// Token: 0x04006DFE RID: 28158
		private static readonly IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0;

		// Token: 0x04006DFF RID: 28159
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0;

		// Token: 0x04006E00 RID: 28160
		private static readonly IntPtr NativeMethodInfoPtr_DeselectConstructable_Public_Void_0;

		// Token: 0x04006E01 RID: 28161
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x04006E02 RID: 28162
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCategories_Private_Void_0;

		// Token: 0x04006E03 RID: 28163
		private static readonly IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_String_0;

		// Token: 0x04006E04 RID: 28164
		private static readonly IntPtr NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0;

		// Token: 0x04006E05 RID: 28165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E06 RID: 28166
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x04006E07 RID: 28167
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_1_Private_Void_0;

		// Token: 0x02000BC1 RID: 3009
		[Serializable]
		public class ConstructionMenuCategory : Il2CppSystem.Object
		{
			// Token: 0x0600DD94 RID: 56724 RVA: 0x00345198 File Offset: 0x00343398
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuCategory()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryName");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryIcon");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "button");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "container");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "listings");
				ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, 100683349);
			}

			// Token: 0x0600DD95 RID: 56725 RVA: 0x0034523C File Offset: 0x0034343C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286411, XrefRangeEnd = 286423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD96 RID: 56726 RVA: 0x0006BF9D File Offset: 0x0006A19D
			public ConstructionMenuCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0600DD97 RID: 56727 RVA: 0x00345278 File Offset: 0x00343478
			// (set) Token: 0x0600DD98 RID: 56728 RVA: 0x0006BFA6 File Offset: 0x0006A1A6
			public unsafe string categoryName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044A8 RID: 17576
			// (get) Token: 0x0600DD99 RID: 56729 RVA: 0x003452A0 File Offset: 0x003434A0
			// (set) Token: 0x0600DD9A RID: 56730 RVA: 0x0006BFC5 File Offset: 0x0006A1C5
			public unsafe Sprite categoryIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A9 RID: 17577
			// (get) Token: 0x0600DD9B RID: 56731 RVA: 0x003452D0 File Offset: 0x003434D0
			// (set) Token: 0x0600DD9C RID: 56732 RVA: 0x0006BFE4 File Offset: 0x0006A1E4
			public unsafe Button button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AA RID: 17578
			// (get) Token: 0x0600DD9D RID: 56733 RVA: 0x00345300 File Offset: 0x00343500
			// (set) Token: 0x0600DD9E RID: 56734 RVA: 0x0006C003 File Offset: 0x0006A203
			public unsafe RectTransform container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AB RID: 17579
			// (get) Token: 0x0600DD9F RID: 56735 RVA: 0x00345330 File Offset: 0x00343530
			// (set) Token: 0x0600DDA0 RID: 56736 RVA: 0x0006C022 File Offset: 0x0006A222
			public unsafe List<ConstructionMenu.ConstructionMenuListing> listings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuListing>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400946D RID: 37997
			private static readonly IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x0400946E RID: 37998
			private static readonly IntPtr NativeFieldInfoPtr_categoryIcon;

			// Token: 0x0400946F RID: 37999
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04009470 RID: 38000
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04009471 RID: 38001
			private static readonly IntPtr NativeFieldInfoPtr_listings;

			// Token: 0x04009472 RID: 38002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC2 RID: 3010
		public class ConstructionMenuListing : Il2CppSystem.Object
		{
			// Token: 0x0600DDA1 RID: 56737 RVA: 0x00345360 File Offset: 0x00343560
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuListing()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "ID");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "price");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "category");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "entry");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "isSelected");
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683350);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683351);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683352);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683353);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683354);
			}

			// Token: 0x0600DDA2 RID: 56738 RVA: 0x00345454 File Offset: 0x00343654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286423, XrefRangeEnd = 286437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuListing(string id, float _price, ConstructionMenu.ConstructionMenuCategory _cat) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _price;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_cat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA3 RID: 56739 RVA: 0x003454C0 File Offset: 0x003436C0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 286510, RefRangeEnd = 286513, XrefRangeStart = 286437, XrefRangeEnd = 286510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateUI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA4 RID: 56740 RVA: 0x003454F4 File Offset: 0x003436F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286513, XrefRangeEnd = 286530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingClicked()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA5 RID: 56741 RVA: 0x00345528 File Offset: 0x00343728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286530, XrefRangeEnd = 286531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingUnselected()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA6 RID: 56742 RVA: 0x0034555C File Offset: 0x0034375C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 286559, RefRangeEnd = 286562, XrefRangeStart = 286531, XrefRangeEnd = 286559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSelected(bool selected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA7 RID: 56743 RVA: 0x0006C041 File Offset: 0x0006A241
			public ConstructionMenuListing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AC RID: 17580
			// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x0034559C File Offset: 0x0034379C
			// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x0006C04A File Offset: 0x0006A24A
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044AD RID: 17581
			// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x003455C4 File Offset: 0x003437C4
			// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x0006C069 File Offset: 0x0006A269
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x170044AE RID: 17582
			// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x003455EC File Offset: 0x003437EC
			// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x0006C084 File Offset: 0x0006A284
			public unsafe ConstructionMenu.ConstructionMenuCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AF RID: 17583
			// (get) Token: 0x0600DDAE RID: 56750 RVA: 0x0034561C File Offset: 0x0034381C
			// (set) Token: 0x0600DDAF RID: 56751 RVA: 0x0006C0A3 File Offset: 0x0006A2A3
			public unsafe RectTransform entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B0 RID: 17584
			// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x0034564C File Offset: 0x0034384C
			// (set) Token: 0x0600DDB1 RID: 56753 RVA: 0x0006C0C2 File Offset: 0x0006A2C2
			public unsafe bool isSelected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected)) = value;
				}
			}

			// Token: 0x04009473 RID: 38003
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x04009474 RID: 38004
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04009475 RID: 38005
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009476 RID: 38006
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009477 RID: 38007
			private static readonly IntPtr NativeFieldInfoPtr_isSelected;

			// Token: 0x04009478 RID: 38008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0;

			// Token: 0x04009479 RID: 38009
			private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Private_Void_0;

			// Token: 0x0400947A RID: 38010
			private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Private_Void_0;

			// Token: 0x0400947B RID: 38011
			private static readonly IntPtr NativeMethodInfoPtr_ListingUnselected_Public_Void_0;

			// Token: 0x0400947C RID: 38012
			private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;
		}

		// Token: 0x02000BC3 RID: 3011
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDB2 RID: 56754 RVA: 0x00345674 File Offset: 0x00343874
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, "category");
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683355);
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683356);
			}

			// Token: 0x0600DDB3 RID: 56755 RVA: 0x003456DC File Offset: 0x003438DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDB4 RID: 56756 RVA: 0x00345718 File Offset: 0x00343918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddListing_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDB5 RID: 56757 RVA: 0x0006C0DD File Offset: 0x0006A2DD
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B1 RID: 17585
			// (get) Token: 0x0600DDB6 RID: 56758 RVA: 0x00345768 File Offset: 0x00343968
			// (set) Token: 0x0600DDB7 RID: 56759 RVA: 0x0006C0E6 File Offset: 0x0006A2E6
			public unsafe string category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400947D RID: 38013
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400947E RID: 38014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400947F RID: 38015
			private static readonly IntPtr NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}

		// Token: 0x02000BC4 RID: 3012
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDB8 RID: 56760 RVA: 0x00345790 File Offset: 0x00343990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "catName");
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683357);
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683358);
			}

			// Token: 0x0600DDB9 RID: 56761 RVA: 0x0034580C File Offset: 0x00343A0C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBA RID: 56762 RVA: 0x00345848 File Offset: 0x00343A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286562, XrefRangeEnd = 286564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateCategories_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBB RID: 56763 RVA: 0x0006C105 File Offset: 0x0006A305
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B2 RID: 17586
			// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x0034587C File Offset: 0x00343A7C
			// (set) Token: 0x0600DDBD RID: 56765 RVA: 0x0006C10E File Offset: 0x0006A30E
			public unsafe string catName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044B3 RID: 17587
			// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x003458A4 File Offset: 0x00343AA4
			// (set) Token: 0x0600DDBF RID: 56767 RVA: 0x0006C12D File Offset: 0x0006A32D
			public unsafe ConstructionMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009480 RID: 38016
			private static readonly IntPtr NativeFieldInfoPtr_catName;

			// Token: 0x04009481 RID: 38017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009482 RID: 38018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009483 RID: 38019
			private static readonly IntPtr NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0;
		}

		// Token: 0x02000BC5 RID: 3013
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDC0 RID: 56768 RVA: 0x003458D4 File Offset: 0x00343AD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, "categoryName");
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683359);
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683360);
			}

			// Token: 0x0600DDC1 RID: 56769 RVA: 0x0034593C File Offset: 0x00343B3C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDC2 RID: 56770 RVA: 0x00345978 File Offset: 0x00343B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectCategory_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDC3 RID: 56771 RVA: 0x0006C14C File Offset: 0x0006A34C
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B4 RID: 17588
			// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x003459C8 File Offset: 0x00343BC8
			// (set) Token: 0x0600DDC5 RID: 56773 RVA: 0x0006C155 File Offset: 0x0006A355
			public unsafe string categoryName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009484 RID: 38020
			private static readonly IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x04009485 RID: 38021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009486 RID: 38022
			private static readonly IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}
	}
}
