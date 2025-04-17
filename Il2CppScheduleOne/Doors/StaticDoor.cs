using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x0200042A RID: 1066
	public class StaticDoor : MonoBehaviour
	{
		// Token: 0x06005DC0 RID: 24000 RVA: 0x001B030C File Offset: 0x001AE50C
		// Note: this type is marked as 'beforefieldinit'.
		static StaticDoor()
		{
			Il2CppClassPointerStore<StaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "StaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr);
			StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "KNOCK_COOLDOWN");
			StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "SUMMON_DURATION");
			StaticDoor.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "AccessPoint");
			StaticDoor.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "IntObj");
			StaticDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "KnockSound");
			StaticDoor.NativeFieldInfoPtr_Building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "Building");
			StaticDoor.NativeFieldInfoPtr_Usable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "Usable");
			StaticDoor.NativeFieldInfoPtr_CanKnock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "CanKnock");
			StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "timeSinceLastKnock");
			StaticDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675226);
			StaticDoor.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675227);
			StaticDoor.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675228);
			StaticDoor.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675229);
			StaticDoor.NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675230);
			StaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675231);
			StaticDoor.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675232);
			StaticDoor.NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675233);
			StaticDoor.NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675234);
			StaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675235);
			StaticDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100675236);
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x001B04CC File Offset: 0x001AE6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196023, XrefRangeEnd = 196053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x001B0508 File Offset: 0x001AE708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196053, XrefRangeEnd = 196077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x001B0544 File Offset: 0x001AE744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196077, XrefRangeEnd = 196078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x001B0580 File Offset: 0x001AE780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196078, XrefRangeEnd = 196079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x001B05BC File Offset: 0x001AE7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196079, XrefRangeEnd = 196083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanKnockNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x001B0604 File Offset: 0x001AE804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196083, XrefRangeEnd = 196086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x001B0668 File Offset: 0x001AE868
		[CallerCount(0)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x001B06A4 File Offset: 0x001AE8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196086, XrefRangeEnd = 196097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x001B06E0 File Offset: 0x001AE8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196097, XrefRangeEnd = 196102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x001B0730 File Offset: 0x001AE930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x001B076C File Offset: 0x001AE96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196102, XrefRangeEnd = 196107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x0002C378 File Offset: 0x0002A578
		public StaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x001B07AC File Offset: 0x001AE9AC
		// (set) Token: 0x06005DCE RID: 24014 RVA: 0x0002C381 File Offset: 0x0002A581
		public unsafe static float KNOCK_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x001B07C8 File Offset: 0x001AE9C8
		// (set) Token: 0x06005DD0 RID: 24016 RVA: 0x0002C38F File Offset: 0x0002A58F
		public unsafe static float SUMMON_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x001B07E4 File Offset: 0x001AE9E4
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x0002C39D File Offset: 0x0002A59D
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06005DD3 RID: 24019 RVA: 0x001B0814 File Offset: 0x001AEA14
		// (set) Token: 0x06005DD4 RID: 24020 RVA: 0x0002C3BC File Offset: 0x0002A5BC
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x001B0844 File Offset: 0x001AEA44
		// (set) Token: 0x06005DD6 RID: 24022 RVA: 0x0002C3DB File Offset: 0x0002A5DB
		public unsafe AudioSourceController KnockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_KnockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x001B0874 File Offset: 0x001AEA74
		// (set) Token: 0x06005DD8 RID: 24024 RVA: 0x0002C3FA File Offset: 0x0002A5FA
		public unsafe NPCEnterableBuilding Building
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Building);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Building), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06005DD9 RID: 24025 RVA: 0x001B08A4 File Offset: 0x001AEAA4
		// (set) Token: 0x06005DDA RID: 24026 RVA: 0x0002C419 File Offset: 0x0002A619
		public unsafe bool Usable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Usable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Usable)) = value;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06005DDB RID: 24027 RVA: 0x001B08CC File Offset: 0x001AEACC
		// (set) Token: 0x06005DDC RID: 24028 RVA: 0x0002C434 File Offset: 0x0002A634
		public unsafe bool CanKnock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_CanKnock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_CanKnock)) = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06005DDD RID: 24029 RVA: 0x001B08F4 File Offset: 0x001AEAF4
		// (set) Token: 0x06005DDE RID: 24030 RVA: 0x0002C44F File Offset: 0x0002A64F
		public unsafe float timeSinceLastKnock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock)) = value;
			}
		}

		// Token: 0x04004023 RID: 16419
		private static readonly IntPtr NativeFieldInfoPtr_KNOCK_COOLDOWN;

		// Token: 0x04004024 RID: 16420
		private static readonly IntPtr NativeFieldInfoPtr_SUMMON_DURATION;

		// Token: 0x04004025 RID: 16421
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04004026 RID: 16422
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004027 RID: 16423
		private static readonly IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x04004028 RID: 16424
		private static readonly IntPtr NativeFieldInfoPtr_Building;

		// Token: 0x04004029 RID: 16425
		private static readonly IntPtr NativeFieldInfoPtr_Usable;

		// Token: 0x0400402A RID: 16426
		private static readonly IntPtr NativeFieldInfoPtr_CanKnock;

		// Token: 0x0400402B RID: 16427
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastKnock;

		// Token: 0x0400402C RID: 16428
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400402D RID: 16429
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x0400402E RID: 16430
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400402F RID: 16431
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04004030 RID: 16432
		private static readonly IntPtr NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004031 RID: 16433
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04004032 RID: 16434
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x04004033 RID: 16435
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0;

		// Token: 0x04004034 RID: 16436
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0;

		// Token: 0x04004035 RID: 16437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004036 RID: 16438
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009F1 RID: 2545
		[ObfuscatedName("ScheduleOne.Doors.StaticDoor+<<Knock>g__knockRoutine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CDBB RID: 52667 RVA: 0x003187B0 File Offset: 0x003169B0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique()
			{
				Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "<<Knock>g__knockRoutine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>1__state");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>2__current");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>4__this");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675237);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675238);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675239);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675240);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675241);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100675242);
			}

			// Token: 0x0600CDBC RID: 52668 RVA: 0x00318890 File Offset: 0x00316A90
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDBD RID: 52669 RVA: 0x003188D8 File Offset: 0x00316AD8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDBE RID: 52670 RVA: 0x0031890C File Offset: 0x00316B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196008, XrefRangeEnd = 196018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700400C RID: 16396
			// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x00318948 File Offset: 0x00316B48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDC0 RID: 52672 RVA: 0x00318988 File Offset: 0x00316B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196018, XrefRangeEnd = 196023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700400D RID: 16397
			// (get) Token: 0x0600CDC1 RID: 52673 RVA: 0x003189BC File Offset: 0x00316BBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDC2 RID: 52674 RVA: 0x000640BF File Offset: 0x000622BF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004009 RID: 16393
			// (get) Token: 0x0600CDC3 RID: 52675 RVA: 0x003189FC File Offset: 0x00316BFC
			// (set) Token: 0x0600CDC4 RID: 52676 RVA: 0x000640C8 File Offset: 0x000622C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700400A RID: 16394
			// (get) Token: 0x0600CDC5 RID: 52677 RVA: 0x00318A24 File Offset: 0x00316C24
			// (set) Token: 0x0600CDC6 RID: 52678 RVA: 0x000640E3 File Offset: 0x000622E3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400B RID: 16395
			// (get) Token: 0x0600CDC7 RID: 52679 RVA: 0x00318A54 File Offset: 0x00316C54
			// (set) Token: 0x0600CDC8 RID: 52680 RVA: 0x00064102 File Offset: 0x00062302
			public unsafe StaticDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AFA RID: 35578
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AFB RID: 35579
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AFC RID: 35580
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AFD RID: 35581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AFE RID: 35582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AFF RID: 35583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B00 RID: 35584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B01 RID: 35585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B02 RID: 35586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
