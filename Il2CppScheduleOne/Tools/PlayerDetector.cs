using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000546 RID: 1350
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x06007765 RID: 30565 RVA: 0x00206058 File Offset: 0x00204258
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDetector()
		{
			Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr);
			PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectPlayerInVehicle");
			PlayerDetector.NativeFieldInfoPtr_onPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_DetectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectedPlayers");
			PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			PlayerDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ignoreExit");
			PlayerDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "collidersEnabled");
			PlayerDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "detectionColliders");
			PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678339);
			PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678340);
			PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678341);
			PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678342);
			PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678343);
			PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678344);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678345);
			PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678346);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678347);
			PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678348);
			PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678349);
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x00206240 File Offset: 0x00204440
		// (set) Token: 0x06007767 RID: 30567 RVA: 0x0020627C File Offset: 0x0020447C
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x002062BC File Offset: 0x002044BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231586, XrefRangeEnd = 231603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x002062F0 File Offset: 0x002044F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231603, XrefRangeEnd = 231621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x00206324 File Offset: 0x00204524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231621, XrefRangeEnd = 231639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00206358 File Offset: 0x00204558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231639, XrefRangeEnd = 231655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x0020638C File Offset: 0x0020458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231655, XrefRangeEnd = 231708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x002063D0 File Offset: 0x002045D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231708, XrefRangeEnd = 231721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00206404 File Offset: 0x00204604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231774, RefRangeEnd = 231775, XrefRangeStart = 231721, XrefRangeEnd = 231774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00206448 File Offset: 0x00204648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231782, RefRangeEnd = 231784, XrefRangeStart = 231775, XrefRangeEnd = 231782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00206488 File Offset: 0x00204688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231784, XrefRangeEnd = 231792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x0003886D File Offset: 0x00036A6D
		public PlayerDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x06007772 RID: 30578 RVA: 0x002064C4 File Offset: 0x002046C4
		// (set) Token: 0x06007773 RID: 30579 RVA: 0x00038876 File Offset: 0x00036A76
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x06007774 RID: 30580 RVA: 0x002064E0 File Offset: 0x002046E0
		// (set) Token: 0x06007775 RID: 30581 RVA: 0x00038884 File Offset: 0x00036A84
		public unsafe bool DetectPlayerInVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle)) = value;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x06007776 RID: 30582 RVA: 0x00206508 File Offset: 0x00204708
		// (set) Token: 0x06007777 RID: 30583 RVA: 0x0003889F File Offset: 0x00036A9F
		public unsafe UnityEvent<Player> onPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06007778 RID: 30584 RVA: 0x00206538 File Offset: 0x00204738
		// (set) Token: 0x06007779 RID: 30585 RVA: 0x000388BE File Offset: 0x00036ABE
		public unsafe UnityEvent<Player> onPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x00206568 File Offset: 0x00204768
		// (set) Token: 0x0600777B RID: 30587 RVA: 0x000388DD File Offset: 0x00036ADD
		public unsafe UnityEvent onLocalPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600777C RID: 30588 RVA: 0x00206598 File Offset: 0x00204798
		// (set) Token: 0x0600777D RID: 30589 RVA: 0x000388FC File Offset: 0x00036AFC
		public unsafe UnityEvent onLocalPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600777E RID: 30590 RVA: 0x002065C8 File Offset: 0x002047C8
		// (set) Token: 0x0600777F RID: 30591 RVA: 0x0003891B File Offset: 0x00036B1B
		public unsafe List<Player> DetectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x002065F8 File Offset: 0x002047F8
		// (set) Token: 0x06007781 RID: 30593 RVA: 0x0003893A File Offset: 0x00036B3A
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x00206620 File Offset: 0x00204820
		// (set) Token: 0x06007783 RID: 30595 RVA: 0x00038955 File Offset: 0x00036B55
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x00206648 File Offset: 0x00204848
		// (set) Token: 0x06007785 RID: 30597 RVA: 0x00038970 File Offset: 0x00036B70
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06007786 RID: 30598 RVA: 0x00206670 File Offset: 0x00204870
		// (set) Token: 0x06007787 RID: 30599 RVA: 0x0003898B File Offset: 0x00036B8B
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400517C RID: 20860
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x0400517D RID: 20861
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerInVehicle;

		// Token: 0x0400517E RID: 20862
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnter;

		// Token: 0x0400517F RID: 20863
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExit;

		// Token: 0x04005180 RID: 20864
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerEnter;

		// Token: 0x04005181 RID: 20865
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExit;

		// Token: 0x04005182 RID: 20866
		private static readonly IntPtr NativeFieldInfoPtr_DetectedPlayers;

		// Token: 0x04005183 RID: 20867
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x04005184 RID: 20868
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x04005185 RID: 20869
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005186 RID: 20870
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x04005187 RID: 20871
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x04005188 RID: 20872
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x04005189 RID: 20873
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400518A RID: 20874
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400518B RID: 20875
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400518C RID: 20876
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400518D RID: 20877
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x0400518E RID: 20878
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400518F RID: 20879
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04005190 RID: 20880
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x04005191 RID: 20881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
