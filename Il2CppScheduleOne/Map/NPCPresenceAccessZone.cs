using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000780 RID: 1920
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x0600B5C2 RID: 46530 RVA: 0x002D2BF0 File Offset: 0x002D0DF0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPresenceAccessZone()
		{
			Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPresenceAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr);
			NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "CooldownTime");
			NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "DetectionZone");
			NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "TargetNPC");
			NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "timeSinceNPCSensed");
			NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685640);
			NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685641);
			NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685642);
			NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685643);
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x002D2CC0 File Offset: 0x002D0EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310366, XrefRangeEnd = 310367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x002D2CFC File Offset: 0x002D0EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310367, XrefRangeEnd = 310383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x002D2D38 File Offset: 0x002D0F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310383, XrefRangeEnd = 310390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x002D2D74 File Offset: 0x002D0F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310391, RefRangeEnd = 310392, XrefRangeStart = 310390, XrefRangeEnd = 310391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPresenceAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00059340 File Offset: 0x00057540
		public NPCPresenceAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x002D2DB0 File Offset: 0x002D0FB0
		// (set) Token: 0x0600B5C9 RID: 46537 RVA: 0x00059349 File Offset: 0x00057549
		public unsafe static float CooldownTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&value));
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x002D2DCC File Offset: 0x002D0FCC
		// (set) Token: 0x0600B5CB RID: 46539 RVA: 0x00059357 File Offset: 0x00057557
		public unsafe Collider DetectionZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x002D2DFC File Offset: 0x002D0FFC
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x00059376 File Offset: 0x00057576
		public unsafe NPC TargetNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x002D2E2C File Offset: 0x002D102C
		// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x00059395 File Offset: 0x00057595
		public unsafe float timeSinceNPCSensed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed)) = value;
			}
		}

		// Token: 0x04007A79 RID: 31353
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04007A7A RID: 31354
		private static readonly IntPtr NativeFieldInfoPtr_DetectionZone;

		// Token: 0x04007A7B RID: 31355
		private static readonly IntPtr NativeFieldInfoPtr_TargetNPC;

		// Token: 0x04007A7C RID: 31356
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceNPCSensed;

		// Token: 0x04007A7D RID: 31357
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A7E RID: 31358
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007A7F RID: 31359
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007A80 RID: 31360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
