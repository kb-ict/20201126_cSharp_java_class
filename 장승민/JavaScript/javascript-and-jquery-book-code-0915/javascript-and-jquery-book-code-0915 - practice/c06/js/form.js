var elForm, elSelectPackage, elPackageHint, elTerms, elTermsHint;
elForm = document.getElementById('formSignup');
elSelectPackage = document.getElementById('package');
elPackageHint = document.getElementById('packageHint');
elTerms = document.getElementById('terms');
elTermsHint = document.getElementById('termsHint');

function packageHint(){
    var package = this.options[this.selectedIndex].value;
    if(package ==='monthly'){
        elPackageHint.innerHTML = '1년 패키지를 사용하시면 10불을 절약할 수 있습니다.';

    } else {
        elPackageHint.innerHTML = '탁월한 선택입니다!';
    }
}
function checkTerms(event){
    if(!elTerms.checked){
        elTermsHint.innerHTML = '사용권 계약에 동의해야 합니다.';
        event.preventDefault();
    }
}
elForm.addEventListener('submit', checkTerms, false);
elSelectPackage.addEventListener('change', packageHint, false);