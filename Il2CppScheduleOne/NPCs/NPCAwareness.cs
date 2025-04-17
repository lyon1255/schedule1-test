using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D5 RID: 725
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x06003414 RID: 13332 RVA: 0x0011758C File Offset: 0x0011578C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAwareness()
		{
			Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAwareness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr);
			NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "PLAYER_AIM_DETECTION_RANGE");
			NPCAwareness.NativeFieldInfoPtr_VisionCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "VisionCone");
			NPCAwareness.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Listener");
			NPCAwareness.NativeFieldInfoPtr_Responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Responses");
			NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedGeneralCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPettyCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedDrugDealing");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPlayerViolatingCurfew");
			NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedSuspiciousPlayer");
			NPCAwareness.NativeFieldInfoPtr_onGunshotHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onGunshotHeard");
			NPCAwareness.NativeFieldInfoPtr_onExplosionHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onExplosionHeard");
			NPCAwareness.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onHitByCar");
			NPCAwareness.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "npc");
			NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669179);
			NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669180);
			NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669181);
			NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669182);
			NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669183);
			NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669184);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00117738 File Offset: 0x00115938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134822, XrefRangeEnd = 134863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00117774 File Offset: 0x00115974
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134867, RefRangeEnd = 134876, XrefRangeStart = 134863, XrefRangeEnd = 134867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAwarenessActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x001177B4 File Offset: 0x001159B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134876, XrefRangeEnd = 134889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisionEvent(VisionEventReceipt vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x001177F8 File Offset: 0x001159F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134889, XrefRangeEnd = 134902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoiseEvent(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x0011783C File Offset: 0x00115A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134902, XrefRangeEnd = 134909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00117880 File Offset: 0x00115A80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAwareness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x0001B7E4 File Offset: 0x000199E4
		public NPCAwareness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x001178BC File Offset: 0x00115ABC
		// (set) Token: 0x0600341D RID: 13341 RVA: 0x0001B7ED File Offset: 0x000199ED
		public unsafe static float PLAYER_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x001178D8 File Offset: 0x00115AD8
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x0001B7FB File Offset: 0x000199FB
		public unsafe VisionCone VisionCone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x00117908 File Offset: 0x00115B08
		// (set) Token: 0x06003421 RID: 13345 RVA: 0x0001B81A File Offset: 0x00019A1A
		public unsafe Listener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06003422 RID: 13346 RVA: 0x00117938 File Offset: 0x00115B38
		// (set) Token: 0x06003423 RID: 13347 RVA: 0x0001B839 File Offset: 0x00019A39
		public unsafe NPCResponses Responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x00117968 File Offset: 0x00115B68
		// (set) Token: 0x06003425 RID: 13349 RVA: 0x0001B858 File Offset: 0x00019A58
		public unsafe UnityEvent<Player> onNoticedGeneralCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x00117998 File Offset: 0x00115B98
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x0001B877 File Offset: 0x00019A77
		public unsafe UnityEvent<Player> onNoticedPettyCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x001179C8 File Offset: 0x00115BC8
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x0001B896 File Offset: 0x00019A96
		public unsafe UnityEvent<Player> onNoticedDrugDealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x001179F8 File Offset: 0x00115BF8
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x0001B8B5 File Offset: 0x00019AB5
		public unsafe UnityEvent<Player> onNoticedPlayerViolatingCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x00117A28 File Offset: 0x00115C28
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x0001B8D4 File Offset: 0x00019AD4
		public unsafe UnityEvent<Player> onNoticedSuspiciousPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x00117A58 File Offset: 0x00115C58
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x0001B8F3 File Offset: 0x00019AF3
		public unsafe UnityEvent<NoiseEvent> onGunshotHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x00117A88 File Offset: 0x00115C88
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x0001B912 File Offset: 0x00019B12
		public unsafe UnityEvent<NoiseEvent> onExplosionHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x00117AB8 File Offset: 0x00115CB8
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x0001B931 File Offset: 0x00019B31
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x00117AE8 File Offset: 0x00115CE8
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x0001B950 File Offset: 0x00019B50
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeFieldInfoPtr_VisionCone;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeFieldInfoPtr_Responses;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedGeneralCrime;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPettyCrime;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedDrugDealing;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedSuspiciousPlayer;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeFieldInfoPtr_onGunshotHeard;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeFieldInfoPtr_onExplosionHeard;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
