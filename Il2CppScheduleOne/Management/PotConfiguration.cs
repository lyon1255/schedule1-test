using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200038E RID: 910
	public class PotConfiguration : EntityConfiguration
	{
		// Token: 0x06004794 RID: 18324 RVA: 0x0015EF70 File Offset: 0x0015D170
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfiguration()
		{
			Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PotConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr);
			PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "<Pot>k__BackingField");
			PotConfiguration.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Seed");
			PotConfiguration.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive1");
			PotConfiguration.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive2");
			PotConfiguration.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive3");
			PotConfiguration.NativeFieldInfoPtr_AssignedBotanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "AssignedBotanist");
			PotConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Destination");
			PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			PotConfiguration.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672148);
			PotConfiguration.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672149);
			PotConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672150);
			PotConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672151);
			PotConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672152);
			PotConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672153);
			PotConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672154);
			PotConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672155);
			PotConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672156);
			PotConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672157);
			PotConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672158);
			PotConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672159);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672160);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672161);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672162);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672163);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672164);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100672165);
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x0015F1A8 File Offset: 0x0015D3A8
		// (set) Token: 0x06004796 RID: 18326 RVA: 0x0015F1E8 File Offset: 0x0015D3E8
		public unsafe Pot Pot
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x0015F22C File Offset: 0x0015D42C
		// (set) Token: 0x06004798 RID: 18328 RVA: 0x0015F26C File Offset: 0x0015D46C
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22967, RefRangeEnd = 22968, XrefRangeStart = 22967, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0015F2B0 File Offset: 0x0015D4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161204, RefRangeEnd = 161205, XrefRangeStart = 161084, XrefRangeEnd = 161204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x0015F320 File Offset: 0x0015D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161205, XrefRangeEnd = 161217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x0015F35C File Offset: 0x0015D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161217, XrefRangeEnd = 161226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x0015F3A0 File Offset: 0x0015D5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161226, XrefRangeEnd = 161243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x0015F408 File Offset: 0x0015D608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161243, XrefRangeEnd = 161244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x0015F444 File Offset: 0x0015D644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161244, XrefRangeEnd = 161245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x0015F480 File Offset: 0x0015D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161245, XrefRangeEnd = 161264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0015F4C8 File Offset: 0x0015D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161264, XrefRangeEnd = 161274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0015F50C File Offset: 0x0015D70C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0015F550 File Offset: 0x0015D750
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_1(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x0015F594 File Offset: 0x0015D794
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_2(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0015F5D8 File Offset: 0x0015D7D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_3(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x0015F61C File Offset: 0x0015D81C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_4(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x0015F660 File Offset: 0x0015D860
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_5(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00022A0C File Offset: 0x00020C0C
		public PotConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0015F6A4 File Offset: 0x0015D8A4
		// (set) Token: 0x060047A9 RID: 18345 RVA: 0x00022A15 File Offset: 0x00020C15
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x0015F6D4 File Offset: 0x0015D8D4
		// (set) Token: 0x060047AB RID: 18347 RVA: 0x00022A34 File Offset: 0x00020C34
		public unsafe ItemField Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x0015F704 File Offset: 0x0015D904
		// (set) Token: 0x060047AD RID: 18349 RVA: 0x00022A53 File Offset: 0x00020C53
		public unsafe ItemField Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x0015F734 File Offset: 0x0015D934
		// (set) Token: 0x060047AF RID: 18351 RVA: 0x00022A72 File Offset: 0x00020C72
		public unsafe ItemField Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x0015F764 File Offset: 0x0015D964
		// (set) Token: 0x060047B1 RID: 18353 RVA: 0x00022A91 File Offset: 0x00020C91
		public unsafe ItemField Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x0015F794 File Offset: 0x0015D994
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x00022AB0 File Offset: 0x00020CB0
		public unsafe NPCField AssignedBotanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_AssignedBotanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_AssignedBotanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x0015F7C4 File Offset: 0x0015D9C4
		// (set) Token: 0x060047B5 RID: 18357 RVA: 0x00022ACF File Offset: 0x00020CCF
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x0015F7F4 File Offset: 0x0015D9F4
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00022AEE File Offset: 0x00020CEE
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003031 RID: 12337
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBotanist;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0;

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0;
	}
}
