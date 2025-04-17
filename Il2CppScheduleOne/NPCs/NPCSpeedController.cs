using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DB RID: 731
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x060035EC RID: 13804 RVA: 0x0011E024 File Offset: 0x0011C224
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSpeedController()
		{
			Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr);
			NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "DefaultWalkSpeed");
			NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedMultiplier");
			NPCSpeedController.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "Movement");
			NPCSpeedController.NativeFieldInfoPtr_speedControlStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "speedControlStack");
			NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "ActiveSpeedControl");
			NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669414);
			NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669415);
			NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669416);
			NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669417);
			NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669418);
			NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669419);
			NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669420);
			NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669421);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0011E158 File Offset: 0x0011C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138022, XrefRangeEnd = 138030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0011E18C File Offset: 0x0011C38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138030, XrefRangeEnd = 138044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0011E1C0 File Offset: 0x0011C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138044, XrefRangeEnd = 138048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0011E200 File Offset: 0x0011C400
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 138071, RefRangeEnd = 138093, XrefRangeStart = 138048, XrefRangeEnd = 138071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0011E244 File Offset: 0x0011C444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138093, XrefRangeEnd = 138108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0011E294 File Offset: 0x0011C494
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 138122, RefRangeEnd = 138129, XrefRangeStart = 138108, XrefRangeEnd = 138122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesSpeedControlExist(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0011E2E4 File Offset: 0x0011C4E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 138146, RefRangeEnd = 138163, XrefRangeStart = 138129, XrefRangeEnd = 138146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0011E328 File Offset: 0x0011C528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138163, XrefRangeEnd = 138171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0001C4F1 File Offset: 0x0001A6F1
		public NPCSpeedController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x0011E364 File Offset: 0x0011C564
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0001C4FA File Offset: 0x0001A6FA
		public unsafe float DefaultWalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed)) = value;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x0011E38C File Offset: 0x0011C58C
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x0001C515 File Offset: 0x0001A715
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x0011E3B4 File Offset: 0x0011C5B4
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x0001C530 File Offset: 0x0001A730
		public unsafe NPCMovement Movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x0011E3E4 File Offset: 0x0011C5E4
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x0001C54F File Offset: 0x0001A74F
		public unsafe List<NPCSpeedController.SpeedControl> speedControlStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCSpeedController.SpeedControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x0011E414 File Offset: 0x0011C614
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x0001C56E File Offset: 0x0001A76E
		public unsafe NPCSpeedController.SpeedControl ActiveSpeedControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeFieldInfoPtr_DefaultWalkSpeed;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeFieldInfoPtr_Movement;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeFieldInfoPtr_speedControlStack;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSpeedControl;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000926 RID: 2342
		[Serializable]
		public class SpeedControl : Il2CppSystem.Object
		{
			// Token: 0x0600C67A RID: 50810 RVA: 0x0030328C File Offset: 0x0030148C
			// Note: this type is marked as 'beforefieldinit'.
			static SpeedControl()
			{
				Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedControl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr);
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "id");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "priority");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "speed");
				NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, 100669422);
			}

			// Token: 0x0600C67B RID: 50811 RVA: 0x00303308 File Offset: 0x00301508
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 137971, RefRangeEnd = 137992, XrefRangeStart = 137969, XrefRangeEnd = 137971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpeedControl(string id, int priority, float speed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C67C RID: 50812 RVA: 0x000609CC File Offset: 0x0005EBCC
			public SpeedControl(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD8 RID: 15832
			// (get) Token: 0x0600C67D RID: 50813 RVA: 0x00303370 File Offset: 0x00301570
			// (set) Token: 0x0600C67E RID: 50814 RVA: 0x000609D5 File Offset: 0x0005EBD5
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DD9 RID: 15833
			// (get) Token: 0x0600C67F RID: 50815 RVA: 0x00303398 File Offset: 0x00301598
			// (set) Token: 0x0600C680 RID: 50816 RVA: 0x000609F4 File Offset: 0x0005EBF4
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x17003DDA RID: 15834
			// (get) Token: 0x0600C681 RID: 50817 RVA: 0x003033C0 File Offset: 0x003015C0
			// (set) Token: 0x0600C682 RID: 50818 RVA: 0x00060A0F File Offset: 0x0005EC0F
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x0400865E RID: 34398
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400865F RID: 34399
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x04008660 RID: 34400
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x04008661 RID: 34401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
		}

		// Token: 0x02000927 RID: 2343
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C683 RID: 50819 RVA: 0x003033E8 File Offset: 0x003015E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669423);
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669424);
			}

			// Token: 0x0600C684 RID: 50820 RVA: 0x00303450 File Offset: 0x00301650
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C685 RID: 50821 RVA: 0x0030348C File Offset: 0x0030168C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C686 RID: 50822 RVA: 0x00060A2A File Offset: 0x0005EC2A
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDB RID: 15835
			// (get) Token: 0x0600C687 RID: 50823 RVA: 0x003034DC File Offset: 0x003016DC
			// (set) Token: 0x0600C688 RID: 50824 RVA: 0x00060A33 File Offset: 0x0005EC33
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008662 RID: 34402
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008663 RID: 34403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008664 RID: 34404
			private static readonly IntPtr NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000928 RID: 2344
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C689 RID: 50825 RVA: 0x00303504 File Offset: 0x00301704
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669425);
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669426);
			}

			// Token: 0x0600C68A RID: 50826 RVA: 0x0030356C File Offset: 0x0030176C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C68B RID: 50827 RVA: 0x003035A8 File Offset: 0x003017A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C68C RID: 50828 RVA: 0x00060A52 File Offset: 0x0005EC52
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDC RID: 15836
			// (get) Token: 0x0600C68D RID: 50829 RVA: 0x003035F8 File Offset: 0x003017F8
			// (set) Token: 0x0600C68E RID: 50830 RVA: 0x00060A5B File Offset: 0x0005EC5B
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008665 RID: 34405
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008666 RID: 34406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008667 RID: 34407
			private static readonly IntPtr NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000929 RID: 2345
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C68F RID: 50831 RVA: 0x00303620 File Offset: 0x00301820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, "control");
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669427);
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669428);
			}

			// Token: 0x0600C690 RID: 50832 RVA: 0x00303688 File Offset: 0x00301888
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C691 RID: 50833 RVA: 0x003036C4 File Offset: 0x003018C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137992, XrefRangeEnd = 138022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C692 RID: 50834 RVA: 0x00060A7A File Offset: 0x0005EC7A
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDD RID: 15837
			// (get) Token: 0x0600C693 RID: 50835 RVA: 0x00303714 File Offset: 0x00301914
			// (set) Token: 0x0600C694 RID: 50836 RVA: 0x00060A83 File Offset: 0x0005EC83
			public unsafe NPCSpeedController.SpeedControl control
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008668 RID: 34408
			private static readonly IntPtr NativeFieldInfoPtr_control;

			// Token: 0x04008669 RID: 34409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400866A RID: 34410
			private static readonly IntPtr NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}
	}
}
