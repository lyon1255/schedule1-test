using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B5 RID: 1205
	public class BuildStart_Grid : BuildStart_Base
	{
		// Token: 0x060069EC RID: 27116 RVA: 0x001D9E40 File Offset: 0x001D8040
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Grid()
		{
			Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr);
			BuildStart_Grid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676750);
			BuildStart_Grid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676751);
			BuildStart_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676752);
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x001D9EAC File Offset: 0x001D80AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213283, XrefRangeEnd = 213332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Grid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x001D9EFC File Offset: 0x001D80FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213332, XrefRangeEnd = 213379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Grid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x001D9F58 File Offset: 0x001D8158
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x000320EE File Offset: 0x000302EE
		public BuildStart_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400488C RID: 18572
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400488D RID: 18573
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0;

		// Token: 0x0400488E RID: 18574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
