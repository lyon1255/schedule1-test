using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CC RID: 1740
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x06009C48 RID: 40008 RVA: 0x0027986C File Offset: 0x00277A6C
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListFieldUI()
		{
			Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr);
			RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			RouteListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldText");
			RouteListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldLabel");
			RouteListFieldUI.NativeFieldInfoPtr_RouteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "RouteEntries");
			RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "MultiEditBlocker");
			RouteListFieldUI.NativeFieldInfoPtr_AddButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "AddButton");
			RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682483);
			RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682484);
			RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682485);
			RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682486);
			RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682487);
			RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682488);
			RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682489);
			RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682490);
			RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682491);
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06009C49 RID: 40009 RVA: 0x002799C8 File Offset: 0x00277BC8
		// (set) Token: 0x06009C4A RID: 40010 RVA: 0x00279A08 File Offset: 0x00277C08
		public unsafe List<RouteListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x00279A4C File Offset: 0x00277C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277178, XrefRangeEnd = 277200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x00279A80 File Offset: 0x00277C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277229, RefRangeEnd = 277230, XrefRangeStart = 277200, XrefRangeEnd = 277229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<RouteListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x00279AC4 File Offset: 0x00277CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277311, RefRangeEnd = 277312, XrefRangeStart = 277230, XrefRangeEnd = 277311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<AdvancedTransitRoute> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x00279B08 File Offset: 0x00277D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277312, XrefRangeEnd = 277318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryDeleteClicked(RouteEntryUI entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x00279B4C File Offset: 0x00277D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277318, XrefRangeEnd = 277327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00279B80 File Offset: 0x00277D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277327, XrefRangeEnd = 277332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RouteChanged(ITransitEntity newEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x00279BC4 File Offset: 0x00277DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277332, XrefRangeEnd = 277344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x0004C9AD File Offset: 0x0004ABAD
		public RouteListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x00279C00 File Offset: 0x00277E00
		// (set) Token: 0x06009C54 RID: 40020 RVA: 0x0004C9B6 File Offset: 0x0004ABB6
		public unsafe List<RouteListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x06009C55 RID: 40021 RVA: 0x00279C30 File Offset: 0x00277E30
		// (set) Token: 0x06009C56 RID: 40022 RVA: 0x0004C9D5 File Offset: 0x0004ABD5
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x06009C57 RID: 40023 RVA: 0x00279C58 File Offset: 0x00277E58
		// (set) Token: 0x06009C58 RID: 40024 RVA: 0x0004C9F4 File Offset: 0x0004ABF4
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x00279C88 File Offset: 0x00277E88
		// (set) Token: 0x06009C5A RID: 40026 RVA: 0x0004CA13 File Offset: 0x0004AC13
		public unsafe Il2CppReferenceArray<RouteEntryUI> RouteEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RouteEntryUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06009C5B RID: 40027 RVA: 0x00279CB8 File Offset: 0x00277EB8
		// (set) Token: 0x06009C5C RID: 40028 RVA: 0x0004CA32 File Offset: 0x0004AC32
		public unsafe RectTransform MultiEditBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06009C5D RID: 40029 RVA: 0x00279CE8 File Offset: 0x00277EE8
		// (set) Token: 0x06009C5E RID: 40030 RVA: 0x0004CA51 File Offset: 0x0004AC51
		public unsafe Button AddButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068FB RID: 26875
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068FC RID: 26876
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x040068FD RID: 26877
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068FE RID: 26878
		private static readonly IntPtr NativeFieldInfoPtr_RouteEntries;

		// Token: 0x040068FF RID: 26879
		private static readonly IntPtr NativeFieldInfoPtr_MultiEditBlocker;

		// Token: 0x04006900 RID: 26880
		private static readonly IntPtr NativeFieldInfoPtr_AddButton;

		// Token: 0x04006901 RID: 26881
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0;

		// Token: 0x04006902 RID: 26882
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0;

		// Token: 0x04006903 RID: 26883
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006904 RID: 26884
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0;

		// Token: 0x04006905 RID: 26885
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0;

		// Token: 0x04006906 RID: 26886
		private static readonly IntPtr NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0;

		// Token: 0x04006907 RID: 26887
		private static readonly IntPtr NativeMethodInfoPtr_AddClicked_Private_Void_0;

		// Token: 0x04006908 RID: 26888
		private static readonly IntPtr NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0;

		// Token: 0x04006909 RID: 26889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8E RID: 2958
		[ObfuscatedName("ScheduleOne.UI.Management.RouteListFieldUI+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBE6 RID: 56294 RVA: 0x00340504 File Offset: 0x0033E704
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr);
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "entry");
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682492);
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682493);
			}

			// Token: 0x0600DBE7 RID: 56295 RVA: 0x00340580 File Offset: 0x0033E780
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE8 RID: 56296 RVA: 0x003405BC File Offset: 0x0033E7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277137, XrefRangeEnd = 277178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE9 RID: 56297 RVA: 0x0006B215 File Offset: 0x00069415
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442E RID: 17454
			// (get) Token: 0x0600DBEA RID: 56298 RVA: 0x003405F0 File Offset: 0x0033E7F0
			// (set) Token: 0x0600DBEB RID: 56299 RVA: 0x0006B21E File Offset: 0x0006941E
			public unsafe RouteEntryUI entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteEntryUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442F RID: 17455
			// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x00340620 File Offset: 0x0033E820
			// (set) Token: 0x0600DBED RID: 56301 RVA: 0x0006B23D File Offset: 0x0006943D
			public unsafe RouteListFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400936D RID: 37741
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400936E RID: 37742
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400936F RID: 37743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009370 RID: 37744
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
