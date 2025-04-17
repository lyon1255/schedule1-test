using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000553 RID: 1363
	public class VerticalLayoutGroupSetter : MonoBehaviour
	{
		// Token: 0x0600780E RID: 30734 RVA: 0x00207C6C File Offset: 0x00205E6C
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalLayoutGroupSetter()
		{
			Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VerticalLayoutGroupSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr);
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "LeftSpacing");
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "layoutGroup");
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678392);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678393);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678394);
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00207D00 File Offset: 0x00205F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232166, XrefRangeEnd = 232170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00207D34 File Offset: 0x00205F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232170, XrefRangeEnd = 232179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00207D68 File Offset: 0x00205F68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalLayoutGroupSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00038E43 File Offset: 0x00037043
		public VerticalLayoutGroupSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x00207DA4 File Offset: 0x00205FA4
		// (set) Token: 0x06007814 RID: 30740 RVA: 0x00038E4C File Offset: 0x0003704C
		public unsafe float LeftSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing)) = value;
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x00207DCC File Offset: 0x00205FCC
		// (set) Token: 0x06007816 RID: 30742 RVA: 0x00038E67 File Offset: 0x00037067
		public unsafe VerticalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051DA RID: 20954
		private static readonly IntPtr NativeFieldInfoPtr_LeftSpacing;

		// Token: 0x040051DB RID: 20955
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x040051DC RID: 20956
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051DD RID: 20957
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040051DE RID: 20958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
