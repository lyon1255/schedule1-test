using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006B4 RID: 1716
	public class ContactsApp : App<ContactsApp>
	{
		// Token: 0x06009A98 RID: 39576 RVA: 0x0027486C File Offset: 0x00272A6C
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsApp()
		{
			Il2CppClassPointerStore<ContactsApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr);
			ContactsApp.NativeFieldInfoPtr_SelectedRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegion");
			ContactsApp.NativeFieldInfoPtr_RegionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionDict");
			ContactsApp.NativeFieldInfoPtr_CirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "CirclesContainer");
			ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DemoCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "TutorialCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionsContainer");
			ContactsApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ContentRect");
			ContactsApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DetailPanel");
			ContactsApp.NativeFieldInfoPtr_RegionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUIs");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_LockedRegionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "LockedRegionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionRankRequirementLabel");
			ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegionIcon");
			ContactsApp.NativeFieldInfoPtr_ConnectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionPrefab");
			ContactsApp.NativeFieldInfoPtr_RelationCircles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RelationCircles");
			ContactsApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "contentMoveRoutine");
			ContactsApp.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "connections");
			ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682316);
			ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682317);
			ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682318);
			ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682319);
			ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682320);
			ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682321);
			ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682322);
			ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682323);
			ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682324);
			ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682325);
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x00274AE0 File Offset: 0x00272CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274693, XrefRangeEnd = 274966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x00274B1C File Offset: 0x00272D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274966, XrefRangeEnd = 274990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x00274B58 File Offset: 0x00272D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275005, RefRangeEnd = 275007, XrefRangeStart = 274990, XrefRangeEnd = 275005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle GetRelationCircle(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr3) : null;
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x00274BA8 File Offset: 0x00272DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275007, XrefRangeEnd = 275011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CircleClicked(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x00274BEC File Offset: 0x00272DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x00274C30 File Offset: 0x00272E30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275044, RefRangeEnd = 275046, XrefRangeStart = 275011, XrefRangeEnd = 275044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRegion(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x00274C70 File Offset: 0x00272E70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 275061, RefRangeEnd = 275068, XrefRangeStart = 275046, XrefRangeEnd = 275061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZoomToRect(RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x00274CB4 File Offset: 0x00272EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275068, XrefRangeEnd = 275069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopContentMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x00274CE8 File Offset: 0x00272EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275069, XrefRangeEnd = 275087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x00274D34 File Offset: 0x00272F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275087, XrefRangeEnd = 275114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x0004B962 File Offset: 0x00049B62
		public ContactsApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x00274D70 File Offset: 0x00272F70
		// (set) Token: 0x06009AA5 RID: 39589 RVA: 0x0004B96B File Offset: 0x00049B6B
		public unsafe EMapRegion SelectedRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion)) = value;
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x00274D98 File Offset: 0x00272F98
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x0004B986 File Offset: 0x00049B86
		public unsafe Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMapRegion, ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00274DC8 File Offset: 0x00272FC8
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x0004B9A5 File Offset: 0x00049BA5
		public unsafe RectTransform CirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x00274DF8 File Offset: 0x00272FF8
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x0004B9C4 File Offset: 0x00049BC4
		public unsafe RectTransform DemoCirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x00274E28 File Offset: 0x00273028
		// (set) Token: 0x06009AAD RID: 39597 RVA: 0x0004B9E3 File Offset: 0x00049BE3
		public unsafe RectTransform TutorialCirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x06009AAE RID: 39598 RVA: 0x00274E58 File Offset: 0x00273058
		// (set) Token: 0x06009AAF RID: 39599 RVA: 0x0004BA02 File Offset: 0x00049C02
		public unsafe RectTransform ConnectionsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x00274E88 File Offset: 0x00273088
		// (set) Token: 0x06009AB1 RID: 39601 RVA: 0x0004BA21 File Offset: 0x00049C21
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x06009AB2 RID: 39602 RVA: 0x00274EB8 File Offset: 0x002730B8
		// (set) Token: 0x06009AB3 RID: 39603 RVA: 0x0004BA40 File Offset: 0x00049C40
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x06009AB4 RID: 39604 RVA: 0x00274EE8 File Offset: 0x002730E8
		// (set) Token: 0x06009AB5 RID: 39605 RVA: 0x0004BA5F File Offset: 0x00049C5F
		public unsafe ContactsDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x06009AB6 RID: 39606 RVA: 0x00274F18 File Offset: 0x00273118
		// (set) Token: 0x06009AB7 RID: 39607 RVA: 0x0004BA7E File Offset: 0x00049C7E
		public unsafe Il2CppReferenceArray<ContactsApp.RegionUI> RegionUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x06009AB8 RID: 39608 RVA: 0x00274F48 File Offset: 0x00273148
		// (set) Token: 0x06009AB9 RID: 39609 RVA: 0x0004BA9D File Offset: 0x00049C9D
		public unsafe RectTransform RegionSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x00274F78 File Offset: 0x00273178
		// (set) Token: 0x06009ABB RID: 39611 RVA: 0x0004BABC File Offset: 0x00049CBC
		public unsafe RectTransform RegionSelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x06009ABC RID: 39612 RVA: 0x00274FA8 File Offset: 0x002731A8
		// (set) Token: 0x06009ABD RID: 39613 RVA: 0x0004BADB File Offset: 0x00049CDB
		public unsafe RectTransform LockedRegionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x06009ABE RID: 39614 RVA: 0x00274FD8 File Offset: 0x002731D8
		// (set) Token: 0x06009ABF RID: 39615 RVA: 0x0004BAFA File Offset: 0x00049CFA
		public unsafe Text RegionRankRequirementLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x00275008 File Offset: 0x00273208
		// (set) Token: 0x06009AC1 RID: 39617 RVA: 0x0004BB19 File Offset: 0x00049D19
		public unsafe Image SelectedRegionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x06009AC2 RID: 39618 RVA: 0x00275038 File Offset: 0x00273238
		// (set) Token: 0x06009AC3 RID: 39619 RVA: 0x0004BB38 File Offset: 0x00049D38
		public unsafe GameObject ConnectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x06009AC4 RID: 39620 RVA: 0x00275068 File Offset: 0x00273268
		// (set) Token: 0x06009AC5 RID: 39621 RVA: 0x0004BB57 File Offset: 0x00049D57
		public unsafe List<RelationCircle> RelationCircles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RelationCircle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x06009AC6 RID: 39622 RVA: 0x00275098 File Offset: 0x00273298
		// (set) Token: 0x06009AC7 RID: 39623 RVA: 0x0004BB76 File Offset: 0x00049D76
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x002750C8 File Offset: 0x002732C8
		// (set) Token: 0x06009AC9 RID: 39625 RVA: 0x0004BB95 File Offset: 0x00049D95
		public unsafe List<Tuple<NPC, NPC>> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<NPC, NPC>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067FC RID: 26620
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRegion;

		// Token: 0x040067FD RID: 26621
		private static readonly IntPtr NativeFieldInfoPtr_RegionDict;

		// Token: 0x040067FE RID: 26622
		private static readonly IntPtr NativeFieldInfoPtr_CirclesContainer;

		// Token: 0x040067FF RID: 26623
		private static readonly IntPtr NativeFieldInfoPtr_DemoCirclesContainer;

		// Token: 0x04006800 RID: 26624
		private static readonly IntPtr NativeFieldInfoPtr_TutorialCirclesContainer;

		// Token: 0x04006801 RID: 26625
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

		// Token: 0x04006802 RID: 26626
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x04006803 RID: 26627
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006804 RID: 26628
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006805 RID: 26629
		private static readonly IntPtr NativeFieldInfoPtr_RegionUIs;

		// Token: 0x04006806 RID: 26630
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionContainer;

		// Token: 0x04006807 RID: 26631
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionIndicator;

		// Token: 0x04006808 RID: 26632
		private static readonly IntPtr NativeFieldInfoPtr_LockedRegionContainer;

		// Token: 0x04006809 RID: 26633
		private static readonly IntPtr NativeFieldInfoPtr_RegionRankRequirementLabel;

		// Token: 0x0400680A RID: 26634
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRegionIcon;

		// Token: 0x0400680B RID: 26635
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionPrefab;

		// Token: 0x0400680C RID: 26636
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircles;

		// Token: 0x0400680D RID: 26637
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x0400680E RID: 26638
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x0400680F RID: 26639
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006810 RID: 26640
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006811 RID: 26641
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0;

		// Token: 0x04006812 RID: 26642
		private static readonly IntPtr NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0;

		// Token: 0x04006813 RID: 26643
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0;

		// Token: 0x04006814 RID: 26644
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0;

		// Token: 0x04006815 RID: 26645
		private static readonly IntPtr NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0;

		// Token: 0x04006816 RID: 26646
		private static readonly IntPtr NativeMethodInfoPtr_StopContentMove_Private_Void_0;

		// Token: 0x04006817 RID: 26647
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006818 RID: 26648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B82 RID: 2946
		[Serializable]
		public class RegionUI : Il2CppSystem.Object
		{
			// Token: 0x0600DB77 RID: 56183 RVA: 0x0033F280 File Offset: 0x0033D480
			// Note: this type is marked as 'beforefieldinit'.
			static RegionUI()
			{
				Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr);
				ContactsApp.RegionUI.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Region");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Button");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Container");
				ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "ConnectionsContainer");
				ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "<npcs>k__BackingField");
				ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682326);
				ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682327);
				ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682328);
			}

			// Token: 0x17004414 RID: 17428
			// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x0033F34C File Offset: 0x0033D54C
			// (set) Token: 0x0600DB79 RID: 56185 RVA: 0x0033F38C File Offset: 0x0033D58C
			public unsafe List<NPC> npcs
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600DB7A RID: 56186 RVA: 0x0033F3D0 File Offset: 0x0033D5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274629, XrefRangeEnd = 274637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB7B RID: 56187 RVA: 0x0006AE53 File Offset: 0x00069053
			public RegionUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440F RID: 17423
			// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x0033F40C File Offset: 0x0033D60C
			// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x0006AE5C File Offset: 0x0006905C
			public unsafe EMapRegion Region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x17004410 RID: 17424
			// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x0033F434 File Offset: 0x0033D634
			// (set) Token: 0x0600DB7F RID: 56191 RVA: 0x0006AE77 File Offset: 0x00069077
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004411 RID: 17425
			// (get) Token: 0x0600DB80 RID: 56192 RVA: 0x0033F464 File Offset: 0x0033D664
			// (set) Token: 0x0600DB81 RID: 56193 RVA: 0x0006AE96 File Offset: 0x00069096
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004412 RID: 17426
			// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x0033F494 File Offset: 0x0033D694
			// (set) Token: 0x0600DB83 RID: 56195 RVA: 0x0006AEB5 File Offset: 0x000690B5
			public unsafe RectTransform ConnectionsContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004413 RID: 17427
			// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x0033F4C4 File Offset: 0x0033D6C4
			// (set) Token: 0x0600DB85 RID: 56197 RVA: 0x0006AED4 File Offset: 0x000690D4
			public unsafe List<NPC> _npcs_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009334 RID: 37684
			private static readonly IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x04009335 RID: 37685
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x04009336 RID: 37686
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009337 RID: 37687
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

			// Token: 0x04009338 RID: 37688
			private static readonly IntPtr NativeFieldInfoPtr__npcs_k__BackingField;

			// Token: 0x04009339 RID: 37689
			private static readonly IntPtr NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0;

			// Token: 0x0400933A RID: 37690
			private static readonly IntPtr NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0;

			// Token: 0x0400933B RID: 37691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B83 RID: 2947
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB86 RID: 56198 RVA: 0x0033F4F4 File Offset: 0x0033D6F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "cacheReg");
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682329);
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682330);
			}

			// Token: 0x0600DB87 RID: 56199 RVA: 0x0033F570 File Offset: 0x0033D770
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB88 RID: 56200 RVA: 0x0033F5AC File Offset: 0x0033D7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274637, XrefRangeEnd = 274639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB89 RID: 56201 RVA: 0x0006AEF3 File Offset: 0x000690F3
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004415 RID: 17429
			// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x0033F5E0 File Offset: 0x0033D7E0
			// (set) Token: 0x0600DB8B RID: 56203 RVA: 0x0006AEFC File Offset: 0x000690FC
			public unsafe ContactsApp.RegionUI cacheReg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.RegionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004416 RID: 17430
			// (get) Token: 0x0600DB8C RID: 56204 RVA: 0x0033F610 File Offset: 0x0033D810
			// (set) Token: 0x0600DB8D RID: 56205 RVA: 0x0006AF1B File Offset: 0x0006911B
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400933C RID: 37692
			private static readonly IntPtr NativeFieldInfoPtr_cacheReg;

			// Token: 0x0400933D RID: 37693
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400933E RID: 37694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400933F RID: 37695
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000B84 RID: 2948
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DB8E RID: 56206 RVA: 0x0033F640 File Offset: 0x0033D840
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "rel");
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682331);
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682332);
			}

			// Token: 0x0600DB8F RID: 56207 RVA: 0x0033F6BC File Offset: 0x0033D8BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB90 RID: 56208 RVA: 0x0033F6F8 File Offset: 0x0033D8F8
			[CallerCount(0)]
			public unsafe bool _Start_b__1(ContactsApp.RegionUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB91 RID: 56209 RVA: 0x0006AF3A File Offset: 0x0006913A
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004417 RID: 17431
			// (get) Token: 0x0600DB92 RID: 56210 RVA: 0x0033F748 File Offset: 0x0033D948
			// (set) Token: 0x0600DB93 RID: 56211 RVA: 0x0006AF43 File Offset: 0x00069143
			public unsafe RelationCircle rel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004418 RID: 17432
			// (get) Token: 0x0600DB94 RID: 56212 RVA: 0x0033F778 File Offset: 0x0033D978
			// (set) Token: 0x0600DB95 RID: 56213 RVA: 0x0006AF62 File Offset: 0x00069162
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009340 RID: 37696
			private static readonly IntPtr NativeFieldInfoPtr_rel;

			// Token: 0x04009341 RID: 37697
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009342 RID: 37698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009343 RID: 37699
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0;
		}

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_2")]
		public sealed class __c__DisplayClass20_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DB96 RID: 56214 RVA: 0x0033F7A8 File Offset: 0x0033D9A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_2()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "other");
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "CS$<>8__locals1");
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682333);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682334);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682335);
			}

			// Token: 0x0600DB97 RID: 56215 RVA: 0x0033F838 File Offset: 0x0033DA38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB98 RID: 56216 RVA: 0x0033F874 File Offset: 0x0033DA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274639, XrefRangeEnd = 274645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__2(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB99 RID: 56217 RVA: 0x0033F8C4 File Offset: 0x0033DAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274645, XrefRangeEnd = 274651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__3(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB9A RID: 56218 RVA: 0x0006AF81 File Offset: 0x00069181
			public __c__DisplayClass20_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004419 RID: 17433
			// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x0033F914 File Offset: 0x0033DB14
			// (set) Token: 0x0600DB9C RID: 56220 RVA: 0x0006AF8A File Offset: 0x0006918A
			public unsafe NPC other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441A RID: 17434
			// (get) Token: 0x0600DB9D RID: 56221 RVA: 0x0033F944 File Offset: 0x0033DB44
			// (set) Token: 0x0600DB9E RID: 56222 RVA: 0x0006AFA9 File Offset: 0x000691A9
			public unsafe ContactsApp.__c__DisplayClass20_1 field_Public___c__DisplayClass20_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009344 RID: 37700
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x04009345 RID: 37701
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0;

			// Token: 0x04009346 RID: 37702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009347 RID: 37703
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0;

			// Token: 0x04009348 RID: 37704
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0;
		}

		// Token: 0x02000B86 RID: 2950
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_3")]
		public sealed class __c__DisplayClass20_3 : Il2CppSystem.Object
		{
			// Token: 0x0600DB9F RID: 56223 RVA: 0x0033F974 File Offset: 0x0033DB74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_3()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "otherCirc");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "cacheRel");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "CS$<>8__locals2");
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682336);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682337);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682338);
			}

			// Token: 0x0600DBA0 RID: 56224 RVA: 0x0033FA18 File Offset: 0x0033DC18
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA1 RID: 56225 RVA: 0x0033FA54 File Offset: 0x0033DC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274651, XrefRangeEnd = 274653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA2 RID: 56226 RVA: 0x0033FA88 File Offset: 0x0033DC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274653, XrefRangeEnd = 274655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA3 RID: 56227 RVA: 0x0006AFC8 File Offset: 0x000691C8
			public __c__DisplayClass20_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441B RID: 17435
			// (get) Token: 0x0600DBA4 RID: 56228 RVA: 0x0033FABC File Offset: 0x0033DCBC
			// (set) Token: 0x0600DBA5 RID: 56229 RVA: 0x0006AFD1 File Offset: 0x000691D1
			public unsafe RelationCircle otherCirc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441C RID: 17436
			// (get) Token: 0x0600DBA6 RID: 56230 RVA: 0x0033FAEC File Offset: 0x0033DCEC
			// (set) Token: 0x0600DBA7 RID: 56231 RVA: 0x0006AFF0 File Offset: 0x000691F0
			public unsafe RelationCircle cacheRel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441D RID: 17437
			// (get) Token: 0x0600DBA8 RID: 56232 RVA: 0x0033FB1C File Offset: 0x0033DD1C
			// (set) Token: 0x0600DBA9 RID: 56233 RVA: 0x0006B00F File Offset: 0x0006920F
			public unsafe ContactsApp.__c__DisplayClass20_2 field_Public___c__DisplayClass20_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009349 RID: 37705
			private static readonly IntPtr NativeFieldInfoPtr_otherCirc;

			// Token: 0x0400934A RID: 37706
			private static readonly IntPtr NativeFieldInfoPtr_cacheRel;

			// Token: 0x0400934B RID: 37707
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0;

			// Token: 0x0400934C RID: 37708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400934D RID: 37709
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_Internal_Void_0;

			// Token: 0x0400934E RID: 37710
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_Internal_Void_0;
		}

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_4")]
		public sealed class __c__DisplayClass20_4 : Il2CppSystem.Object
		{
			// Token: 0x0600DBAA RID: 56234 RVA: 0x0033FB4C File Offset: 0x0033DD4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_4()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "circ");
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682339);
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682340);
			}

			// Token: 0x0600DBAB RID: 56235 RVA: 0x0033FBC8 File Offset: 0x0033DDC8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBAC RID: 56236 RVA: 0x0033FC04 File Offset: 0x0033DE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274655, XrefRangeEnd = 274659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBAD RID: 56237 RVA: 0x0006B02E File Offset: 0x0006922E
			public __c__DisplayClass20_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441E RID: 17438
			// (get) Token: 0x0600DBAE RID: 56238 RVA: 0x0033FC38 File Offset: 0x0033DE38
			// (set) Token: 0x0600DBAF RID: 56239 RVA: 0x0006B037 File Offset: 0x00069237
			public unsafe RelationCircle circ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441F RID: 17439
			// (get) Token: 0x0600DBB0 RID: 56240 RVA: 0x0033FC68 File Offset: 0x0033DE68
			// (set) Token: 0x0600DBB1 RID: 56241 RVA: 0x0006B056 File Offset: 0x00069256
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400934F RID: 37711
			private static readonly IntPtr NativeFieldInfoPtr_circ;

			// Token: 0x04009350 RID: 37712
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009351 RID: 37713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009352 RID: 37714
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_Internal_Void_0;
		}

		// Token: 0x02000B88 RID: 2952
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBB2 RID: 56242 RVA: 0x0033FC98 File Offset: 0x0033DE98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, "npcID");
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682341);
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682342);
			}

			// Token: 0x0600DBB3 RID: 56243 RVA: 0x0033FD00 File Offset: 0x0033DF00
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB4 RID: 56244 RVA: 0x0033FD3C File Offset: 0x0033DF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274659, XrefRangeEnd = 274663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRelationCircle_b__0(RelationCircle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBB5 RID: 56245 RVA: 0x0006B075 File Offset: 0x00069275
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004420 RID: 17440
			// (get) Token: 0x0600DBB6 RID: 56246 RVA: 0x0033FD8C File Offset: 0x0033DF8C
			// (set) Token: 0x0600DBB7 RID: 56247 RVA: 0x0006B07E File Offset: 0x0006927E
			public unsafe string npcID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009353 RID: 37715
			private static readonly IntPtr NativeFieldInfoPtr_npcID;

			// Token: 0x04009354 RID: 37716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009355 RID: 37717
			private static readonly IntPtr NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0;
		}

		// Token: 0x02000B89 RID: 2953
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBB8 RID: 56248 RVA: 0x0033FDB4 File Offset: 0x0033DFB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endPos");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "startScale");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endScale");
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682343);
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682344);
			}

			// Token: 0x0600DBB9 RID: 56249 RVA: 0x0033FE58 File Offset: 0x0033E058
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBBA RID: 56250 RVA: 0x0033FE94 File Offset: 0x0033E094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274688, XrefRangeEnd = 274693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DBBB RID: 56251 RVA: 0x0006B09D File Offset: 0x0006929D
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004421 RID: 17441
			// (get) Token: 0x0600DBBC RID: 56252 RVA: 0x0033FED4 File Offset: 0x0033E0D4
			// (set) Token: 0x0600DBBD RID: 56253 RVA: 0x0006B0A6 File Offset: 0x000692A6
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0600DBBE RID: 56254 RVA: 0x0033FF04 File Offset: 0x0033E104
			// (set) Token: 0x0600DBBF RID: 56255 RVA: 0x0006B0C5 File Offset: 0x000692C5
			public unsafe Vector2 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004423 RID: 17443
			// (get) Token: 0x0600DBC0 RID: 56256 RVA: 0x0033FF2C File Offset: 0x0033E12C
			// (set) Token: 0x0600DBC1 RID: 56257 RVA: 0x0006B0E0 File Offset: 0x000692E0
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004424 RID: 17444
			// (get) Token: 0x0600DBC2 RID: 56258 RVA: 0x0033FF54 File Offset: 0x0033E154
			// (set) Token: 0x0600DBC3 RID: 56259 RVA: 0x0006B0FB File Offset: 0x000692FB
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x04009356 RID: 37718
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009357 RID: 37719
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009358 RID: 37720
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04009359 RID: 37721
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x0400935A RID: 37722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400935B RID: 37723
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7E RID: 3198
			[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0+<<ZoomToRect>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E63A RID: 58938 RVA: 0x0035E2AC File Offset: 0x0035C4AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique()
				{
					Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<<ZoomToRect>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>1__state");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>2__current");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>4__this");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<startPos>5__2");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682345);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682346);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682347);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682348);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682349);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682350);
				}

				// Token: 0x0600E63B RID: 58939 RVA: 0x0035E3C8 File Offset: 0x0035C5C8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E63C RID: 58940 RVA: 0x0035E410 File Offset: 0x0035C610
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E63D RID: 58941 RVA: 0x0035E444 File Offset: 0x0035C644
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274663, XrefRangeEnd = 274683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047AE RID: 18350
				// (get) Token: 0x0600E63E RID: 58942 RVA: 0x0035E480 File Offset: 0x0035C680
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E63F RID: 58943 RVA: 0x0035E4C0 File Offset: 0x0035C6C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274683, XrefRangeEnd = 274688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047AF RID: 18351
				// (get) Token: 0x0600E640 RID: 58944 RVA: 0x0035E4F4 File Offset: 0x0035C6F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E641 RID: 58945 RVA: 0x000705C4 File Offset: 0x0006E7C4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047A8 RID: 18344
				// (get) Token: 0x0600E642 RID: 58946 RVA: 0x0035E534 File Offset: 0x0035C734
				// (set) Token: 0x0600E643 RID: 58947 RVA: 0x000705CD File Offset: 0x0006E7CD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047A9 RID: 18345
				// (get) Token: 0x0600E644 RID: 58948 RVA: 0x0035E55C File Offset: 0x0035C75C
				// (set) Token: 0x0600E645 RID: 58949 RVA: 0x000705E8 File Offset: 0x0006E7E8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047AA RID: 18346
				// (get) Token: 0x0600E646 RID: 58950 RVA: 0x0035E58C File Offset: 0x0035C78C
				// (set) Token: 0x0600E647 RID: 58951 RVA: 0x00070607 File Offset: 0x0006E807
				public unsafe ContactsApp.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047AB RID: 18347
				// (get) Token: 0x0600E648 RID: 58952 RVA: 0x0035E5BC File Offset: 0x0035C7BC
				// (set) Token: 0x0600E649 RID: 58953 RVA: 0x00070626 File Offset: 0x0006E826
				public unsafe Vector2 _startPos_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2)) = value;
					}
				}

				// Token: 0x170047AC RID: 18348
				// (get) Token: 0x0600E64A RID: 58954 RVA: 0x0035E5E4 File Offset: 0x0035C7E4
				// (set) Token: 0x0600E64B RID: 58955 RVA: 0x00070641 File Offset: 0x0006E841
				public unsafe float _lerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x170047AD RID: 18349
				// (get) Token: 0x0600E64C RID: 58956 RVA: 0x0035E60C File Offset: 0x0035C80C
				// (set) Token: 0x0600E64D RID: 58957 RVA: 0x0007065C File Offset: 0x0006E85C
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099E3 RID: 39395
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099E4 RID: 39396
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099E5 RID: 39397
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099E6 RID: 39398
				private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

				// Token: 0x040099E7 RID: 39399
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x040099E8 RID: 39400
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099E9 RID: 39401
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099EA RID: 39402
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099EB RID: 39403
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099EC RID: 39404
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099ED RID: 39405
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099EE RID: 39406
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
