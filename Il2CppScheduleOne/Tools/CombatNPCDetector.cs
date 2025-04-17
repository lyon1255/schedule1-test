using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000531 RID: 1329
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x06007678 RID: 30328 RVA: 0x002033A0 File Offset: 0x002015A0
		// Note: this type is marked as 'beforefieldinit'.
		static CombatNPCDetector()
		{
			Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CombatNPCDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr);
			CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "DetectOnlyInCombat");
			CombatNPCDetector.NativeFieldInfoPtr_onDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "onDetected");
			CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "ContactTimeForDetection");
			CombatNPCDetector.NativeFieldInfoPtr_contactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "contactTime");
			CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "timeSinceLastContact");
			CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678224);
			CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678225);
			CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678226);
			CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678227);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00203484 File Offset: 0x00201684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230813, XrefRangeEnd = 230826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x002034B8 File Offset: 0x002016B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230826, XrefRangeEnd = 230830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x002034EC File Offset: 0x002016EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230830, XrefRangeEnd = 230844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00203530 File Offset: 0x00201730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230844, XrefRangeEnd = 230845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatNPCDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x000381F6 File Offset: 0x000363F6
		public CombatNPCDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600767E RID: 30334 RVA: 0x0020356C File Offset: 0x0020176C
		// (set) Token: 0x0600767F RID: 30335 RVA: 0x000381FF File Offset: 0x000363FF
		public unsafe bool DetectOnlyInCombat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat)) = value;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x06007680 RID: 30336 RVA: 0x00203594 File Offset: 0x00201794
		// (set) Token: 0x06007681 RID: 30337 RVA: 0x0003821A File Offset: 0x0003641A
		public unsafe UnityEvent onDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x002035C4 File Offset: 0x002017C4
		// (set) Token: 0x06007683 RID: 30339 RVA: 0x00038239 File Offset: 0x00036439
		public unsafe float ContactTimeForDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection)) = value;
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x002035EC File Offset: 0x002017EC
		// (set) Token: 0x06007685 RID: 30341 RVA: 0x00038254 File Offset: 0x00036454
		public unsafe float contactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime)) = value;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x00203614 File Offset: 0x00201814
		// (set) Token: 0x06007687 RID: 30343 RVA: 0x0003826F File Offset: 0x0003646F
		public unsafe float timeSinceLastContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact)) = value;
			}
		}

		// Token: 0x040050ED RID: 20717
		private static readonly IntPtr NativeFieldInfoPtr_DetectOnlyInCombat;

		// Token: 0x040050EE RID: 20718
		private static readonly IntPtr NativeFieldInfoPtr_onDetected;

		// Token: 0x040050EF RID: 20719
		private static readonly IntPtr NativeFieldInfoPtr_ContactTimeForDetection;

		// Token: 0x040050F0 RID: 20720
		private static readonly IntPtr NativeFieldInfoPtr_contactTime;

		// Token: 0x040050F1 RID: 20721
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastContact;

		// Token: 0x040050F2 RID: 20722
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050F3 RID: 20723
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040050F4 RID: 20724
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040050F5 RID: 20725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
