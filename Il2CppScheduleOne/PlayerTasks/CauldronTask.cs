using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000205 RID: 517
	public class CauldronTask : Task
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x000F83C8 File Offset: 0x000F65C8
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronTask()
		{
			Il2CppClassPointerStore<CauldronTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "CauldronTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr);
			CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "<Cauldron>k__BackingField");
			CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			CauldronTask.NativeFieldInfoPtr_CocaLeaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "CocaLeaves");
			CauldronTask.NativeFieldInfoPtr_Gasoline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "Gasoline");
			CauldronTask.NativeFieldInfoPtr_Tub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "Tub");
			CauldronTask.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668102);
			CauldronTask.NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668103);
			CauldronTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668104);
			CauldronTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668105);
			CauldronTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668106);
			CauldronTask.NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668107);
			CauldronTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668108);
			CauldronTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668109);
			CauldronTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668110);
			CauldronTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668111);
			CauldronTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668112);
			CauldronTask.NativeMethodInfoPtr_StartMixing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668113);
			CauldronTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668114);
			CauldronTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668115);
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000F8574 File Offset: 0x000F6774
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x000F85B4 File Offset: 0x000F67B4
		public unsafe Cauldron Cauldron
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000F85F8 File Offset: 0x000F67F8
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x000F8634 File Offset: 0x000F6834
		public unsafe CauldronTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79663, RefRangeEnd = 79664, XrefRangeStart = 79663, XrefRangeEnd = 79664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 121043, RefRangeEnd = 121052, XrefRangeStart = 121043, XrefRangeEnd = 121043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000F8674 File Offset: 0x000F6874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121052, XrefRangeEnd = 121056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(CauldronTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000F86AC File Offset: 0x000F68AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121144, RefRangeEnd = 121146, XrefRangeStart = 121056, XrefRangeEnd = 121144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronTask(Cauldron caudron) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(caudron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000F86F8 File Offset: 0x000F68F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121146, XrefRangeEnd = 121163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000F8734 File Offset: 0x000F6934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121163, XrefRangeEnd = 121197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000F8770 File Offset: 0x000F6970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121197, XrefRangeEnd = 121220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000F87AC File Offset: 0x000F69AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121220, XrefRangeEnd = 121232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000F87E0 File Offset: 0x000F69E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121232, XrefRangeEnd = 121244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000F8814 File Offset: 0x000F6A14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121268, RefRangeEnd = 121271, XrefRangeStart = 121244, XrefRangeEnd = 121268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_StartMixing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000F8848 File Offset: 0x000F6A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121271, XrefRangeEnd = 121279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000F887C File Offset: 0x000F6A7C
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00017400 File Offset: 0x00015600
		public CauldronTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000F88B0 File Offset: 0x000F6AB0
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x00017409 File Offset: 0x00015609
		public unsafe Cauldron _Cauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000F88E0 File Offset: 0x000F6AE0
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x00017428 File Offset: 0x00015628
		public unsafe CauldronTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000F8908 File Offset: 0x000F6B08
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00017443 File Offset: 0x00015643
		public unsafe Il2CppReferenceArray<StationItem> CocaLeaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_CocaLeaves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_CocaLeaves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000F8938 File Offset: 0x000F6B38
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x00017462 File Offset: 0x00015662
		public unsafe StationItem Gasoline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Gasoline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Gasoline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x000F8968 File Offset: 0x000F6B68
		// (set) Token: 0x06002AFD RID: 11005 RVA: 0x00017481 File Offset: 0x00015681
		public unsafe Draggable Tub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Tub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Tub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr__Cauldron_k__BackingField;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeaves;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_Gasoline;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeFieldInfoPtr_Tub;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_StartMixing_Private_Void_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x020008DF RID: 2271
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400851E RID: 34078
			CombineIngredients,
			// Token: 0x0400851F RID: 34079
			StartMixing
		}
	}
}
