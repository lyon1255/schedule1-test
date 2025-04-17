using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B3 RID: 1203
	public class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x060069E4 RID: 27108 RVA: 0x001D9C78 File Offset: 0x001D7E78
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Base()
		{
			Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr);
			BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676746);
			BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676747);
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
		[CallerCount(0)]
		public unsafe virtual void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x001D9D20 File Offset: 0x001D7F20
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x000320DC File Offset: 0x000302DC
		public BuildStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004888 RID: 18568
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04004889 RID: 18569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
