using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068E RID: 1678
	public class MonitorDropdown : SettingsDropdown
	{
		// Token: 0x060095E1 RID: 38369 RVA: 0x00266904 File Offset: 0x00264B04
		// Note: this type is marked as 'beforefieldinit'.
		static MonitorDropdown()
		{
			Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "MonitorDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr);
			MonitorDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr, 100681827);
			MonitorDropdown.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr, 100681828);
			MonitorDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr, 100681829);
			MonitorDropdown.NativeMethodInfoPtr_GetCurrentDisplayNumber_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr, 100681830);
			MonitorDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr, 100681831);
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x00266998 File Offset: 0x00264B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268955, XrefRangeEnd = 268966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonitorDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x002669D4 File Offset: 0x00264BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268966, XrefRangeEnd = 268989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonitorDropdown.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x00266A10 File Offset: 0x00264C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268989, XrefRangeEnd = 268998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonitorDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x00266A5C File Offset: 0x00264C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268998, XrefRangeEnd = 269009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCurrentDisplayNumber()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonitorDropdown.NativeMethodInfoPtr_GetCurrentDisplayNumber_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00266A8C File Offset: 0x00264C8C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonitorDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonitorDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonitorDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public MonitorDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400650E RID: 25870
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400650F RID: 25871
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04006510 RID: 25872
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0;

		// Token: 0x04006511 RID: 25873
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDisplayNumber_Public_Static_Int32_0;

		// Token: 0x04006512 RID: 25874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
