using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000391 RID: 913
	public class ConfigField : Object
	{
		// Token: 0x060047BB RID: 18363 RVA: 0x0015F85C File Offset: 0x0015DA5C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigField()
		{
			Il2CppClassPointerStore<ConfigField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigField>.NativeClassPtr);
			ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, "<ParentConfig>k__BackingField");
			ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672167);
			ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672168);
			ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672169);
			ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672170);
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x0015F8F0 File Offset: 0x0015DAF0
		// (set) Token: 0x060047BD RID: 18365 RVA: 0x0015F930 File Offset: 0x0015DB30
		public unsafe EntityConfiguration ParentConfig
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0015F974 File Offset: 0x0015DB74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 161301, RefRangeEnd = 161313, XrefRangeStart = 161293, XrefRangeEnd = 161301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0015F9C0 File Offset: 0x0015DBC0
		[CallerCount(0)]
		public unsafe virtual bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x00022B4F File Offset: 0x00020D4F
		public ConfigField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0015FA08 File Offset: 0x0015DC08
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x00022B58 File Offset: 0x00020D58
		public unsafe EntityConfiguration _ParentConfig_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeFieldInfoPtr__ParentConfig_k__BackingField;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0;
	}
}
