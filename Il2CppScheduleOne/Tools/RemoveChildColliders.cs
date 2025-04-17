using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000549 RID: 1353
	public class RemoveChildColliders : MonoBehaviour
	{
		// Token: 0x0600779E RID: 30622 RVA: 0x00206A40 File Offset: 0x00204C40
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveChildColliders()
		{
			Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RemoveChildColliders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr);
			RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678356);
			RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678357);
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x00206A98 File Offset: 0x00204C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231827, XrefRangeEnd = 231835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00206ACC File Offset: 0x00204CCC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveChildColliders() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00038A66 File Offset: 0x00036C66
		public RemoveChildColliders(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400519E RID: 20894
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400519F RID: 20895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
