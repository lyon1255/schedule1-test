using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000598 RID: 1432
	[Serializable]
	public class CocaineInstance : ProductItemInstance
	{
		// Token: 0x06007DD2 RID: 32210 RVA: 0x0021AE04 File Offset: 0x00219004
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineInstance()
		{
			Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr);
			CocaineInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679028);
			CocaineInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679029);
			CocaineInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679030);
			CocaineInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679031);
			CocaineInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679032);
			CocaineInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679033);
			CocaineInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679034);
			CocaineInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679035);
			CocaineInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr, 100679036);
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x0021AEE8 File Offset: 0x002190E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238244, RefRangeEnd = 238249, XrefRangeStart = 238240, XrefRangeEnd = 238244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x0021AF24 File Offset: 0x00219124
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238250, RefRangeEnd = 238253, XrefRangeStart = 238249, XrefRangeEnd = 238250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x0021AFA0 File Offset: 0x002191A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238253, XrefRangeEnd = 238259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x0021AFF8 File Offset: 0x002191F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238259, XrefRangeEnd = 238286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x0021B048 File Offset: 0x00219248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238286, XrefRangeEnd = 238294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x0021B094 File Offset: 0x00219294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238294, XrefRangeEnd = 238301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x0021B0E4 File Offset: 0x002192E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238301, XrefRangeEnd = 238308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x0021B134 File Offset: 0x00219334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238308, XrefRangeEnd = 238335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x0021B184 File Offset: 0x00219384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238335, XrefRangeEnd = 238363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x0003BD2A File Offset: 0x00039F2A
		public CocaineInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400558E RID: 21902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400558F RID: 21903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x04005590 RID: 21904
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005591 RID: 21905
		private static readonly IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0;

		// Token: 0x04005592 RID: 21906
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005593 RID: 21907
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005594 RID: 21908
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005595 RID: 21909
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04005596 RID: 21910
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0;
	}
}
