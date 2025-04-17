using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E0 RID: 1760
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DEB RID: 40427 RVA: 0x0027ECF0 File Offset: 0x0027CEF0
		// Note: this type is marked as 'beforefieldinit'.
		static PotUIElement()
		{
			Il2CppClassPointerStore<PotUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr);
			PotUIElement.NativeFieldInfoPtr_SeedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "SeedIcon");
			PotUIElement.NativeFieldInfoPtr_NoSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "NoSeed");
			PotUIElement.NativeFieldInfoPtr_Additive1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive1Icon");
			PotUIElement.NativeFieldInfoPtr_Additive2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive2Icon");
			PotUIElement.NativeFieldInfoPtr_Additive3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive3Icon");
			PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682666);
			PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682667);
			PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682668);
			PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682669);
			PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682670);
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009DEC RID: 40428 RVA: 0x0027EDFC File Offset: 0x0027CFFC
		// (set) Token: 0x06009DED RID: 40429 RVA: 0x0027EE3C File Offset: 0x0027D03C
		public unsafe Pot AssignedPot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x0027EE80 File Offset: 0x0027D080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279621, RefRangeEnd = 279622, XrefRangeStart = 279611, XrefRangeEnd = 279621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x0027EEC4 File Offset: 0x0027D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279622, XrefRangeEnd = 279664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x0027EF00 File Offset: 0x0027D100
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x0004D748 File Offset: 0x0004B948
		public PotUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x06009DF2 RID: 40434 RVA: 0x0027EF3C File Offset: 0x0027D13C
		// (set) Token: 0x06009DF3 RID: 40435 RVA: 0x0004D751 File Offset: 0x0004B951
		public unsafe Image SeedIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x0027EF6C File Offset: 0x0027D16C
		// (set) Token: 0x06009DF5 RID: 40437 RVA: 0x0004D770 File Offset: 0x0004B970
		public unsafe GameObject NoSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x0027EF9C File Offset: 0x0027D19C
		// (set) Token: 0x06009DF7 RID: 40439 RVA: 0x0004D78F File Offset: 0x0004B98F
		public unsafe Image Additive1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x0027EFCC File Offset: 0x0027D1CC
		// (set) Token: 0x06009DF9 RID: 40441 RVA: 0x0004D7AE File Offset: 0x0004B9AE
		public unsafe Image Additive2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x0027EFFC File Offset: 0x0027D1FC
		// (set) Token: 0x06009DFB RID: 40443 RVA: 0x0004D7CD File Offset: 0x0004B9CD
		public unsafe Image Additive3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009DFC RID: 40444 RVA: 0x0027F02C File Offset: 0x0027D22C
		// (set) Token: 0x06009DFD RID: 40445 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A06 RID: 27142
		private static readonly IntPtr NativeFieldInfoPtr_SeedIcon;

		// Token: 0x04006A07 RID: 27143
		private static readonly IntPtr NativeFieldInfoPtr_NoSeed;

		// Token: 0x04006A08 RID: 27144
		private static readonly IntPtr NativeFieldInfoPtr_Additive1Icon;

		// Token: 0x04006A09 RID: 27145
		private static readonly IntPtr NativeFieldInfoPtr_Additive2Icon;

		// Token: 0x04006A0A RID: 27146
		private static readonly IntPtr NativeFieldInfoPtr_Additive3Icon;

		// Token: 0x04006A0B RID: 27147
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x04006A0C RID: 27148
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x04006A0D RID: 27149
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x04006A0E RID: 27150
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Pot_0;

		// Token: 0x04006A0F RID: 27151
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A10 RID: 27152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
