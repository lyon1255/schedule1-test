using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003F RID: 63
	public class LookAtTarget : MonoBehaviour
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0007F5F4 File Offset: 0x0007D7F4
		// Note: this type is marked as 'beforefieldinit'.
		static LookAtTarget()
		{
			Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LookAtTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr);
			LookAtTarget.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_target");
			LookAtTarget.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_speed");
			LookAtTarget.NativeFieldInfoPtr__lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_lookAtTarget");
			LookAtTarget.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, 100663737);
			LookAtTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, 100663738);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0007F688 File Offset: 0x0007D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74781, XrefRangeEnd = 74786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtTarget.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0007F6BC File Offset: 0x0007D8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74786, XrefRangeEnd = 74787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAtTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000051C4 File Offset: 0x000033C4
		public LookAtTarget(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x000051CD File Offset: 0x000033CD
		public unsafe Transform _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0007F728 File Offset: 0x0007D928
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x000051EC File Offset: 0x000033EC
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0007F750 File Offset: 0x0007D950
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00005207 File Offset: 0x00003407
		public unsafe Vector3 _lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__lookAtTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__lookAtTarget)) = value;
			}
		}

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr__lookAtTarget;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
