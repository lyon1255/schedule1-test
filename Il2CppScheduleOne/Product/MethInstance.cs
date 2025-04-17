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
	// Token: 0x020005A1 RID: 1441
	[Serializable]
	public class MethInstance : ProductItemInstance
	{
		// Token: 0x06007E08 RID: 32264 RVA: 0x0021BA74 File Offset: 0x00219C74
		// Note: this type is marked as 'beforefieldinit'.
		static MethInstance()
		{
			Il2CppClassPointerStore<MethInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethInstance>.NativeClassPtr);
			MethInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679057);
			MethInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679058);
			MethInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679059);
			MethInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679060);
			MethInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679061);
			MethInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679062);
			MethInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679063);
			MethInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679064);
			MethInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethInstance>.NativeClassPtr, 100679065);
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x0021BB58 File Offset: 0x00219D58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238244, RefRangeEnd = 238249, XrefRangeStart = 238244, XrefRangeEnd = 238249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x0021BB94 File Offset: 0x00219D94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238250, RefRangeEnd = 238253, XrefRangeStart = 238250, XrefRangeEnd = 238253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0021BC10 File Offset: 0x00219E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238530, XrefRangeEnd = 238536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0021BC68 File Offset: 0x00219E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238536, XrefRangeEnd = 238563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0021BCB8 File Offset: 0x00219EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238563, XrefRangeEnd = 238571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x0021BD04 File Offset: 0x00219F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238571, XrefRangeEnd = 238587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0021BD54 File Offset: 0x00219F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238587, XrefRangeEnd = 238595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0021BDA4 File Offset: 0x00219FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238595, XrefRangeEnd = 238625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0021BDF4 File Offset: 0x00219FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238625, XrefRangeEnd = 238654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0003BE2E File Offset: 0x0003A02E
		public MethInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040055C8 RID: 21960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040055C9 RID: 21961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x040055CA RID: 21962
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040055CB RID: 21963
		private static readonly IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_Void_FilledPackagingVisuals_0;

		// Token: 0x040055CC RID: 21964
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040055CD RID: 21965
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040055CE RID: 21966
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040055CF RID: 21967
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x040055D0 RID: 21968
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0;
	}
}
