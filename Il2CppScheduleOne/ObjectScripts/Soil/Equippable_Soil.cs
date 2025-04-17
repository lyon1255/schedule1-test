using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Equipping;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x02000760 RID: 1888
	public class Equippable_Soil : Equippable_Pourable
	{
		// Token: 0x0600B36E RID: 45934 RVA: 0x002CBE5C File Offset: 0x002CA05C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Soil()
		{
			Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "Equippable_Soil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr);
			Equippable_Soil.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_Soil.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100685419);
			Equippable_Soil.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100685420);
			Equippable_Soil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100685421);
			Equippable_Soil.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100685422);
			Equippable_Soil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100685423);
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B36F RID: 45935 RVA: 0x002CBF04 File Offset: 0x002CA104
		// (set) Token: 0x0600B370 RID: 45936 RVA: 0x002CBF48 File Offset: 0x002CA148
		public unsafe override string InteractionLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x002CBF98 File Offset: 0x002CA198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308402, XrefRangeEnd = 308412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x002CC00C File Offset: 0x002CA20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308412, XrefRangeEnd = 308416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x002CC05C File Offset: 0x002CA25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308416, XrefRangeEnd = 308421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Soil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Soil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x00057EC9 File Offset: 0x000560C9
		public Equippable_Soil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B375 RID: 45941 RVA: 0x002CC098 File Offset: 0x002CA298
		// (set) Token: 0x0600B376 RID: 45942 RVA: 0x00057ED2 File Offset: 0x000560D2
		public new unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Soil.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Soil.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007909 RID: 30985
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x0400790A RID: 30986
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0;

		// Token: 0x0400790B RID: 30987
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0;

		// Token: 0x0400790C RID: 30988
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0;

		// Token: 0x0400790D RID: 30989
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0;

		// Token: 0x0400790E RID: 30990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
