using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class CurfewInstance : Object
	{
		// Token: 0x06004B84 RID: 19332 RVA: 0x0016CC40 File Offset: 0x0016AE40
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewInstance()
		{
			Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr);
			CurfewInstance.NativeFieldInfoPtr_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "ActiveInstance");
			CurfewInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "IntensityRequirement");
			CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "<Enabled>k__BackingField");
			CurfewInstance.NativeFieldInfoPtr_shouldDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "shouldDisable");
			CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672651);
			CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672652);
			CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672653);
			CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672654);
			CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672655);
			CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672656);
			CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672657);
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004B85 RID: 19333 RVA: 0x0016CD4C File Offset: 0x0016AF4C
		// (set) Token: 0x06004B86 RID: 19334 RVA: 0x0016CD88 File Offset: 0x0016AF88
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x0016CDC8 File Offset: 0x0016AFC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164786, RefRangeEnd = 164788, XrefRangeStart = 164778, XrefRangeEnd = 164786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(bool ignoreSleepReq = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreSleepReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x0016CE08 File Offset: 0x0016B008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164788, XrefRangeEnd = 164796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x0016CE3C File Offset: 0x0016B03C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164823, RefRangeEnd = 164825, XrefRangeStart = 164796, XrefRangeEnd = 164823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0016CE70 File Offset: 0x0016B070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164847, RefRangeEnd = 164848, XrefRangeStart = 164825, XrefRangeEnd = 164847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x0016CEA4 File Offset: 0x0016B0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164848, XrefRangeEnd = 164849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x000244FF File Offset: 0x000226FF
		public CurfewInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x0016CEE0 File Offset: 0x0016B0E0
		// (set) Token: 0x06004B8E RID: 19342 RVA: 0x00024508 File Offset: 0x00022708
		public unsafe static CurfewInstance ActiveInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurfewInstance>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x0016CF08 File Offset: 0x0016B108
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x0002451A File Offset: 0x0002271A
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x0016CF30 File Offset: 0x0016B130
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x00024535 File Offset: 0x00022735
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x0016CF58 File Offset: 0x0016B158
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x00024550 File Offset: 0x00022750
		public unsafe bool shouldDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable)) = value;
			}
		}

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeFieldInfoPtr_ActiveInstance;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeFieldInfoPtr_shouldDisable;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
