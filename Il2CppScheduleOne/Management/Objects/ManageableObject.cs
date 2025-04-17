using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Objects
{
	// Token: 0x020003B1 RID: 945
	public class ManageableObject : MonoBehaviour
	{
		// Token: 0x060049BB RID: 18875 RVA: 0x00166E2C File Offset: 0x0016502C
		// Note: this type is marked as 'beforefieldinit'.
		static ManageableObject()
		{
			Il2CppClassPointerStore<ManageableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Objects", "ManageableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr);
			ManageableObject.NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672447);
			ManageableObject.NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672448);
			ManageableObject.NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672449);
			ManageableObject.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672450);
			ManageableObject.NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672451);
			ManageableObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672452);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00166ED4 File Offset: 0x001650D4
		[CallerCount(0)]
		public unsafe virtual ManageableObjectType GetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00166F1C File Offset: 0x0016511C
		[CallerCount(0)]
		public unsafe virtual Preset GetCurrentPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00166F68 File Offset: 0x00165168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163509, XrefRangeEnd = 163523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPreset(Preset newPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPreset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00166FAC File Offset: 0x001651AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163523, XrefRangeEnd = 163537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPreset_Internal(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00166FFC File Offset: 0x001651FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExistingPresetDeleted(Preset replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00167040 File Offset: 0x00165240
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManageableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00023855 File Offset: 0x00021A55
		public ManageableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
