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
	// Token: 0x020005B1 RID: 1457
	[Serializable]
	public class WeedInstance : ProductItemInstance
	{
		// Token: 0x06008009 RID: 32777 RVA: 0x00224160 File Offset: 0x00222360
		// Note: this type is marked as 'beforefieldinit'.
		static WeedInstance()
		{
			Il2CppClassPointerStore<WeedInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr);
			WeedInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679380);
			WeedInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679381);
			WeedInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679382);
			WeedInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679383);
			WeedInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679384);
			WeedInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679385);
			WeedInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679386);
			WeedInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679387);
			WeedInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr, 100679388);
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x00224244 File Offset: 0x00222444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243621, XrefRangeEnd = 243622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00224280 File Offset: 0x00222480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238250, RefRangeEnd = 238253, XrefRangeStart = 238250, XrefRangeEnd = 238253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x002242FC File Offset: 0x002224FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243622, XrefRangeEnd = 243628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600800D RID: 32781 RVA: 0x00224354 File Offset: 0x00222554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243628, XrefRangeEnd = 243686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x002243A4 File Offset: 0x002225A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243686, XrefRangeEnd = 243694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x002243F0 File Offset: 0x002225F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243694, XrefRangeEnd = 243699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x00224440 File Offset: 0x00222640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243699, XrefRangeEnd = 243704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x00224490 File Offset: 0x00222690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243704, XrefRangeEnd = 243736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x002244E0 File Offset: 0x002226E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243736, XrefRangeEnd = 243769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x0003CB42 File Offset: 0x0003AD42
		public WeedInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400573A RID: 22330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400573B RID: 22331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x0400573C RID: 22332
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400573D RID: 22333
		private static readonly IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0;

		// Token: 0x0400573E RID: 22334
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x0400573F RID: 22335
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005740 RID: 22336
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005741 RID: 22337
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04005742 RID: 22338
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0;
	}
}
