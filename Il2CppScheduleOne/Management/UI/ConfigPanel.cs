using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management.UI
{
	// Token: 0x020003A8 RID: 936
	public class ConfigPanel : MonoBehaviour
	{
		// Token: 0x06004941 RID: 18753 RVA: 0x00165468 File Offset: 0x00163668
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigPanel()
		{
			Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.UI", "ConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr);
			ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672382);
			ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672383);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001654C0 File Offset: 0x001636C0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00165510 File Offset: 0x00163710
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x000234CA File Offset: 0x000216CA
		public ConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
