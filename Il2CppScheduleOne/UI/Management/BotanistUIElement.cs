using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D5 RID: 1749
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D74 RID: 40308 RVA: 0x0027D340 File Offset: 0x0027B540
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistUIElement()
		{
			Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr);
			BotanistUIElement.NativeFieldInfoPtr_SupplyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyIcon");
			BotanistUIElement.NativeFieldInfoPtr_NoSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "NoSupply");
			BotanistUIElement.NativeFieldInfoPtr_SupplyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyLabel");
			BotanistUIElement.NativeFieldInfoPtr_PotRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "PotRects");
			BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "<AssignedBotanist>k__BackingField");
			BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682611);
			BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682612);
			BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682613);
			BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682614);
			BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682615);
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x06009D75 RID: 40309 RVA: 0x0027D438 File Offset: 0x0027B638
		// (set) Token: 0x06009D76 RID: 40310 RVA: 0x0027D478 File Offset: 0x0027B678
		public unsafe Botanist AssignedBotanist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22967, RefRangeEnd = 22968, XrefRangeStart = 22967, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x0027D4BC File Offset: 0x0027B6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279352, RefRangeEnd = 279353, XrefRangeStart = 279341, XrefRangeEnd = 279352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Botanist bot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x0027D500 File Offset: 0x0027B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279353, XrefRangeEnd = 279390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x0027D53C File Offset: 0x0027B73C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x0004D45A File Offset: 0x0004B65A
		public BotanistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06009D7B RID: 40315 RVA: 0x0027D578 File Offset: 0x0027B778
		// (set) Token: 0x06009D7C RID: 40316 RVA: 0x0004D463 File Offset: 0x0004B663
		public unsafe Image SupplyIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06009D7D RID: 40317 RVA: 0x0027D5A8 File Offset: 0x0027B7A8
		// (set) Token: 0x06009D7E RID: 40318 RVA: 0x0004D482 File Offset: 0x0004B682
		public unsafe GameObject NoSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06009D7F RID: 40319 RVA: 0x0027D5D8 File Offset: 0x0027B7D8
		// (set) Token: 0x06009D80 RID: 40320 RVA: 0x0004D4A1 File Offset: 0x0004B6A1
		public unsafe TextMeshProUGUI SupplyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x06009D81 RID: 40321 RVA: 0x0027D608 File Offset: 0x0027B808
		// (set) Token: 0x06009D82 RID: 40322 RVA: 0x0004D4C0 File Offset: 0x0004B6C0
		public unsafe Il2CppReferenceArray<RectTransform> PotRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x06009D83 RID: 40323 RVA: 0x0027D638 File Offset: 0x0027B838
		// (set) Token: 0x06009D84 RID: 40324 RVA: 0x0004D4DF File Offset: 0x0004B6DF
		public unsafe Botanist _AssignedBotanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069BA RID: 27066
		private static readonly IntPtr NativeFieldInfoPtr_SupplyIcon;

		// Token: 0x040069BB RID: 27067
		private static readonly IntPtr NativeFieldInfoPtr_NoSupply;

		// Token: 0x040069BC RID: 27068
		private static readonly IntPtr NativeFieldInfoPtr_SupplyLabel;

		// Token: 0x040069BD RID: 27069
		private static readonly IntPtr NativeFieldInfoPtr_PotRects;

		// Token: 0x040069BE RID: 27070
		private static readonly IntPtr NativeFieldInfoPtr__AssignedBotanist_k__BackingField;

		// Token: 0x040069BF RID: 27071
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0;

		// Token: 0x040069C0 RID: 27072
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0;

		// Token: 0x040069C1 RID: 27073
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0;

		// Token: 0x040069C2 RID: 27074
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069C3 RID: 27075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
