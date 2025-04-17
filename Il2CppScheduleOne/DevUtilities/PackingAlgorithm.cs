using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000461 RID: 1121
	public class PackingAlgorithm : Singleton<PackingAlgorithm>
	{
		// Token: 0x06006170 RID: 24944 RVA: 0x001BC4C8 File Offset: 0x001BA6C8
		// Note: this type is marked as 'beforefieldinit'.
		static PackingAlgorithm()
		{
			Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PackingAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr);
			PackingAlgorithm.NativeFieldInfoPtr_rectsToPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "rectsToPack");
			PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675673);
			PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675674);
			PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675675);
			PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675676);
			PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675677);
			PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675678);
			PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675679);
			PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675680);
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x001BC5AC File Offset: 0x001BA7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200591, XrefRangeEnd = 200621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(datas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr3) : null;
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x001BC618 File Offset: 0x001BA818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200808, RefRangeEnd = 200809, XrefRangeStart = 200621, XrefRangeEnd = 200808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> AttemptPack(List<PackingAlgorithm.StoredItemData> rects, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr3) : null;
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x001BC684 File Offset: 0x001BA884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200822, RefRangeEnd = 200823, XrefRangeStart = 200809, XrefRangeEnd = 200822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesCoordinateHaveOccupiedAdjacent(Il2CppObjectBase grid, PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x001BC700 File Offset: 0x001BA900
		[CallerCount(0)]
		public unsafe bool IsCoordinateInBounds(PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x001BC76C File Offset: 0x001BA96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200823, XrefRangeEnd = 200841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintGrid(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x001BC7CC File Offset: 0x001BA9CC
		[CallerCount(0)]
		public unsafe int GetRegionSize(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x001BC838 File Offset: 0x001BAA38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 200845, RefRangeEnd = 200852, XrefRangeStart = 200841, XrefRangeEnd = 200845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm.Coordinate TransformCoordinatePoint(Il2CppObjectBase grid, PackingAlgorithm.Coordinate baseCoordinate, PackingAlgorithm.Coordinate offset, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCoordinate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Coordinate>(intPtr3) : null;
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x001BC8C8 File Offset: 0x001BAAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200852, XrefRangeEnd = 200862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x0002E106 File Offset: 0x0002C306
		public PackingAlgorithm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x001BC904 File Offset: 0x001BAB04
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x0002E10F File Offset: 0x0002C30F
		public unsafe List<PackingAlgorithm.Rectangle> rectsToPack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.Rectangle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeFieldInfoPtr_rectsToPack;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0;

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A15 RID: 2581
		[Serializable]
		public class Rectangle : Object
		{
			// Token: 0x0600CEC2 RID: 52930 RVA: 0x0031B618 File Offset: 0x00319818
			// Note: this type is marked as 'beforefieldinit'.
			static Rectangle()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Rectangle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr);
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "name");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeX");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeY");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "flipped");
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675681);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675682);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675683);
			}

			// Token: 0x1700404D RID: 16461
			// (get) Token: 0x0600CEC3 RID: 52931 RVA: 0x0031B6D0 File Offset: 0x003198D0
			public unsafe int actualSizeX
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700404E RID: 16462
			// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x0031B70C File Offset: 0x0031990C
			public unsafe int actualSizeY
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CEC5 RID: 52933 RVA: 0x0031B748 File Offset: 0x00319948
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200586, RefRangeEnd = 200587, XrefRangeStart = 200584, XrefRangeEnd = 200586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rectangle(string _name, int x, int y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEC6 RID: 52934 RVA: 0x000648DF File Offset: 0x00062ADF
			public Rectangle(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004049 RID: 16457
			// (get) Token: 0x0600CEC7 RID: 52935 RVA: 0x0031B7B0 File Offset: 0x003199B0
			// (set) Token: 0x0600CEC8 RID: 52936 RVA: 0x000648E8 File Offset: 0x00062AE8
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700404A RID: 16458
			// (get) Token: 0x0600CEC9 RID: 52937 RVA: 0x0031B7D8 File Offset: 0x003199D8
			// (set) Token: 0x0600CECA RID: 52938 RVA: 0x00064907 File Offset: 0x00062B07
			public unsafe int sizeX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX)) = value;
				}
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0600CECB RID: 52939 RVA: 0x0031B800 File Offset: 0x00319A00
			// (set) Token: 0x0600CECC RID: 52940 RVA: 0x00064922 File Offset: 0x00062B22
			public unsafe int sizeY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY)) = value;
				}
			}

			// Token: 0x1700404C RID: 16460
			// (get) Token: 0x0600CECD RID: 52941 RVA: 0x0031B828 File Offset: 0x00319A28
			// (set) Token: 0x0600CECE RID: 52942 RVA: 0x0006493D File Offset: 0x00062B3D
			public unsafe bool flipped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped)) = value;
				}
			}

			// Token: 0x04008B82 RID: 35714
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008B83 RID: 35715
			private static readonly IntPtr NativeFieldInfoPtr_sizeX;

			// Token: 0x04008B84 RID: 35716
			private static readonly IntPtr NativeFieldInfoPtr_sizeY;

			// Token: 0x04008B85 RID: 35717
			private static readonly IntPtr NativeFieldInfoPtr_flipped;

			// Token: 0x04008B86 RID: 35718
			private static readonly IntPtr NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0;

			// Token: 0x04008B87 RID: 35719
			private static readonly IntPtr NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0;

			// Token: 0x04008B88 RID: 35720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000A16 RID: 2582
		public class StoredItemData : PackingAlgorithm.Rectangle
		{
			// Token: 0x0600CECF RID: 52943 RVA: 0x0031B850 File Offset: 0x00319A50
			// Note: this type is marked as 'beforefieldinit'.
			static StoredItemData()
			{
				Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "StoredItemData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr);
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "item");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "xPos");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "yPos");
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100675684);
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100675685);
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x0031B8E0 File Offset: 0x00319AE0
			public unsafe float rotation
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CED1 RID: 52945 RVA: 0x0031B91C File Offset: 0x00319B1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200590, RefRangeEnd = 200591, XrefRangeStart = 200587, XrefRangeEnd = 200590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StoredItemData(string _name, int x, int y, ItemInstance _item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CED2 RID: 52946 RVA: 0x00064958 File Offset: 0x00062B58
			public StoredItemData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404F RID: 16463
			// (get) Token: 0x0600CED3 RID: 52947 RVA: 0x0031B998 File Offset: 0x00319B98
			// (set) Token: 0x0600CED4 RID: 52948 RVA: 0x00064961 File Offset: 0x00062B61
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004050 RID: 16464
			// (get) Token: 0x0600CED5 RID: 52949 RVA: 0x0031B9C8 File Offset: 0x00319BC8
			// (set) Token: 0x0600CED6 RID: 52950 RVA: 0x00064980 File Offset: 0x00062B80
			public unsafe int xPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos)) = value;
				}
			}

			// Token: 0x17004051 RID: 16465
			// (get) Token: 0x0600CED7 RID: 52951 RVA: 0x0031B9F0 File Offset: 0x00319BF0
			// (set) Token: 0x0600CED8 RID: 52952 RVA: 0x0006499B File Offset: 0x00062B9B
			public unsafe int yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x04008B89 RID: 35721
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008B8A RID: 35722
			private static readonly IntPtr NativeFieldInfoPtr_xPos;

			// Token: 0x04008B8B RID: 35723
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04008B8C RID: 35724
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

			// Token: 0x04008B8D RID: 35725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0;
		}

		// Token: 0x02000A17 RID: 2583
		public class Coordinate : Object
		{
			// Token: 0x0600CED9 RID: 52953 RVA: 0x0031BA18 File Offset: 0x00319C18
			// Note: this type is marked as 'beforefieldinit'.
			static Coordinate()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Coordinate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr);
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "x");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "y");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "occupant");
				PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, 100675686);
			}

			// Token: 0x0600CEDA RID: 52954 RVA: 0x0031BA94 File Offset: 0x00319C94
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 110517, RefRangeEnd = 110534, XrefRangeStart = 110517, XrefRangeEnd = 110534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coordinate(int _x, int _y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEDB RID: 52955 RVA: 0x000649B6 File Offset: 0x00062BB6
			public Coordinate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0600CEDC RID: 52956 RVA: 0x0031BAEC File Offset: 0x00319CEC
			// (set) Token: 0x0600CEDD RID: 52957 RVA: 0x000649BF File Offset: 0x00062BBF
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x0031BB14 File Offset: 0x00319D14
			// (set) Token: 0x0600CEDF RID: 52959 RVA: 0x000649DA File Offset: 0x00062BDA
			public unsafe int y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17004055 RID: 16469
			// (get) Token: 0x0600CEE0 RID: 52960 RVA: 0x0031BB3C File Offset: 0x00319D3C
			// (set) Token: 0x0600CEE1 RID: 52961 RVA: 0x000649F5 File Offset: 0x00062BF5
			public unsafe PackingAlgorithm.Rectangle occupant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Rectangle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B8E RID: 35726
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008B8F RID: 35727
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008B90 RID: 35728
			private static readonly IntPtr NativeFieldInfoPtr_occupant;

			// Token: 0x04008B91 RID: 35729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x02000A18 RID: 2584
		[ObfuscatedName("ScheduleOne.DevUtilities.PackingAlgorithm+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CEE2 RID: 52962 RVA: 0x0031BB6C File Offset: 0x00319D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr);
				PackingAlgorithm.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9");
				PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9__5_0");
				PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100675688);
				PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100675689);
			}

			// Token: 0x0600CEE3 RID: 52963 RVA: 0x0031BBE8 File Offset: 0x00319DE8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEE4 RID: 52964 RVA: 0x0031BC24 File Offset: 0x00319E24
			[CallerCount(0)]
			public unsafe int _AttemptPack_b__5_0(PackingAlgorithm.StoredItemData o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEE5 RID: 52965 RVA: 0x00064A14 File Offset: 0x00062C14
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004056 RID: 16470
			// (get) Token: 0x0600CEE6 RID: 52966 RVA: 0x0031BC74 File Offset: 0x00319E74
			// (set) Token: 0x0600CEE7 RID: 52967 RVA: 0x00064A1D File Offset: 0x00062C1D
			public unsafe static PackingAlgorithm.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004057 RID: 16471
			// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x0031BC9C File Offset: 0x00319E9C
			// (set) Token: 0x0600CEE9 RID: 52969 RVA: 0x00064A2F File Offset: 0x00062C2F
			public unsafe static Func<PackingAlgorithm.StoredItemData, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PackingAlgorithm.StoredItemData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B92 RID: 35730
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B93 RID: 35731
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04008B94 RID: 35732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B95 RID: 35733
			private static readonly IntPtr NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0;
		}
	}
}
