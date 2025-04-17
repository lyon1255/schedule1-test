using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000393 RID: 915
	public class NPCField : ConfigField
	{
		// Token: 0x060047D4 RID: 18388 RVA: 0x0015FDE8 File Offset: 0x0015DFE8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCField()
		{
			Il2CppClassPointerStore<NPCField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NPCField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCField>.NativeClassPtr);
			NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			NPCField.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "TypeRequirement");
			NPCField.NativeFieldInfoPtr_onNPCChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "onNPCChanged");
			NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672178);
			NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672179);
			NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672180);
			NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672181);
			NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672182);
			NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672183);
			NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672184);
			NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672185);
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0015FEF4 File Offset: 0x0015E0F4
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x0015FF34 File Offset: 0x0015E134
		public unsafe NPC SelectedNPC
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0015FF78 File Offset: 0x0015E178
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 161377, RefRangeEnd = 161385, XrefRangeStart = 161369, XrefRangeEnd = 161377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0015FFC4 File Offset: 0x0015E1C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 161394, RefRangeEnd = 161408, XrefRangeStart = 161385, XrefRangeEnd = 161394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x00160014 File Offset: 0x0015E214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161408, XrefRangeEnd = 161412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesNPCMatchRequirement(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00160064 File Offset: 0x0015E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161412, XrefRangeEnd = 161416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x001600AC File Offset: 0x0015E2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161416, XrefRangeEnd = 161428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCFieldData>(intPtr3) : null;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x001600EC File Offset: 0x0015E2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161428, XrefRangeEnd = 161441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00022BF8 File Offset: 0x00020DF8
		public NPCField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x00160130 File Offset: 0x0015E330
		// (set) Token: 0x060047DF RID: 18399 RVA: 0x00022C01 File Offset: 0x00020E01
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x00160160 File Offset: 0x0015E360
		// (set) Token: 0x060047E1 RID: 18401 RVA: 0x00022C20 File Offset: 0x00020E20
		public unsafe Type TypeRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x00160190 File Offset: 0x0015E390
		// (set) Token: 0x060047E3 RID: 18403 RVA: 0x00022C3F File Offset: 0x00020E3F
		public unsafe UnityEvent<NPC> onNPCChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeFieldInfoPtr_onNPCChanged;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NPCFieldData_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0;
	}
}
