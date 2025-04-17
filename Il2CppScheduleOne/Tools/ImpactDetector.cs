using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053D RID: 1341
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x06007707 RID: 30471 RVA: 0x00204EC8 File Offset: 0x002030C8
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactDetector()
		{
			Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ImpactDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr);
			ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "DestroyScriptOnImpact");
			ImpactDetector.NativeFieldInfoPtr_onImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "onImpact");
			ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678303);
			ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678304);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00204F48 File Offset: 0x00203148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231359, XrefRangeEnd = 231364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00204F8C File Offset: 0x0020318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231364, XrefRangeEnd = 231370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x000385EE File Offset: 0x000367EE
		public ImpactDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600770B RID: 30475 RVA: 0x00204FC8 File Offset: 0x002031C8
		// (set) Token: 0x0600770C RID: 30476 RVA: 0x000385F7 File Offset: 0x000367F7
		public unsafe bool DestroyScriptOnImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact)) = value;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600770D RID: 30477 RVA: 0x00204FF0 File Offset: 0x002031F0
		// (set) Token: 0x0600770E RID: 30478 RVA: 0x00038612 File Offset: 0x00036812
		public unsafe UnityEvent onImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005144 RID: 20804
		private static readonly IntPtr NativeFieldInfoPtr_DestroyScriptOnImpact;

		// Token: 0x04005145 RID: 20805
		private static readonly IntPtr NativeFieldInfoPtr_onImpact;

		// Token: 0x04005146 RID: 20806
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04005147 RID: 20807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
