using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000414 RID: 1044
	[StructLayout(2)]
	public struct DealWindowInfo
	{
		// Token: 0x06005B78 RID: 23416 RVA: 0x001A88AC File Offset: 0x001A6AAC
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowInfo()
		{
			Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealWindowInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr);
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_DURATION_MINS");
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_COUNT");
			DealWindowInfo.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "StartTime");
			DealWindowInfo.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "EndTime");
			DealWindowInfo.NativeFieldInfoPtr_Morning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Morning");
			DealWindowInfo.NativeFieldInfoPtr_Afternoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Afternoon");
			DealWindowInfo.NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Night");
			DealWindowInfo.NativeFieldInfoPtr_LateNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "LateNight");
			DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674970);
			DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674971);
			DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674972);
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x001A89B8 File Offset: 0x001A6BB8
		[CallerCount(93)]
		[CachedScanResults(RefRangeStart = 34314, RefRangeEnd = 34407, XrefRangeStart = 34314, XrefRangeEnd = 34407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowInfo(int startTime, int endTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x001A89F8 File Offset: 0x001A6BF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193306, RefRangeEnd = 193309, XrefRangeStart = 193302, XrefRangeEnd = 193306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x001A8A38 File Offset: 0x001A6C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193315, RefRangeEnd = 193317, XrefRangeStart = 193309, XrefRangeEnd = 193315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow GetWindow(int time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x0002B235 File Offset: 0x00029435
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x001A8A78 File Offset: 0x001A6C78
		// (set) Token: 0x06005B7E RID: 23422 RVA: 0x0002B247 File Offset: 0x00029447
		public unsafe static int WINDOW_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x001A8A94 File Offset: 0x001A6C94
		// (set) Token: 0x06005B80 RID: 23424 RVA: 0x0002B255 File Offset: 0x00029455
		public unsafe static int WINDOW_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x001A8AB0 File Offset: 0x001A6CB0
		// (set) Token: 0x06005B82 RID: 23426 RVA: 0x0002B263 File Offset: 0x00029463
		public unsafe static DealWindowInfo Morning
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&value));
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005B83 RID: 23427 RVA: 0x001A8ACC File Offset: 0x001A6CCC
		// (set) Token: 0x06005B84 RID: 23428 RVA: 0x0002B271 File Offset: 0x00029471
		public unsafe static DealWindowInfo Afternoon
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&value));
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06005B85 RID: 23429 RVA: 0x001A8AE8 File Offset: 0x001A6CE8
		// (set) Token: 0x06005B86 RID: 23430 RVA: 0x0002B27F File Offset: 0x0002947F
		public unsafe static DealWindowInfo Night
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&value));
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x001A8B04 File Offset: 0x001A6D04
		// (set) Token: 0x06005B88 RID: 23432 RVA: 0x0002B28D File Offset: 0x0002948D
		public unsafe static DealWindowInfo LateNight
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&value));
			}
		}

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_DURATION_MINS;

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_COUNT;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeFieldInfoPtr_Morning;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeFieldInfoPtr_Afternoon;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeFieldInfoPtr_Night;

		// Token: 0x04003E92 RID: 16018
		private static readonly IntPtr NativeFieldInfoPtr_LateNight;

		// Token: 0x04003E93 RID: 16019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04003E94 RID: 16020
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0;

		// Token: 0x04003E95 RID: 16021
		private static readonly IntPtr NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0;

		// Token: 0x04003E96 RID: 16022
		[FieldOffset(0)]
		public int StartTime;

		// Token: 0x04003E97 RID: 16023
		[FieldOffset(4)]
		public int EndTime;
	}
}
